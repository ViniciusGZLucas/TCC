using CrossCutting.DataSession;
using Domain.Interface;
using Domain.Interface.BusinessRule.Base;

namespace BusinessRule.Base
{
    public abstract class BaseBusinessRule<TRepository, TDTO, TViewModel, TInputCreateViewModel> : IBaseBusinessRule<TRepository, TDTO, TViewModel, TInputCreateViewModel>
    {
        protected readonly TRepository _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseBusinessRule(TRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public TDTO Create(DataSession dataSession, TInputCreateViewModel viewModel)
        {
            ViewModelValidationProcess(viewModel);

            var viewModelProperties = typeof(TInputCreateViewModel).GetProperties();
            var viewModelPropertiesName = viewModelProperties.Select(x => x.Name).ToList();
            var dtoProperties = typeof(TDTO).GetProperties().Where(x => viewModelPropertiesName.Contains(x.Name)).ToList();

            var entryType = typeof(TRepository).UnderlyingSystemType.GetInterfaces().ToList().FirstOrDefault()?.GenericTypeArguments.ToList().FirstOrDefault();

            var newEntry = Activator.CreateInstance(entryType);
            var newDTO = Activator.CreateInstance(typeof(TDTO));

            var entryProperties = entryType.GetProperties().Where(x => viewModelPropertiesName.Contains(x.Name)).ToList();

            for (var x = 0; x < viewModelProperties.Count(); x++)
            {
                var entryProperty = entryProperties[x];
                var viewModelProperty = viewModelProperties[x];
                var dtosProperty = dtoProperties[x];

                entryProperty.SetValue(newEntry, viewModelProperty.GetValue(viewModel));
                dtosProperty.SetValue(newDTO, viewModelProperty.GetValue(viewModel));
            }

            DTOValidationProcess((TDTO)newDTO);

            SetCreationValues(dataSession, newEntry);

            _unitOfWork.StartTransaction();

            try
            {
                var method = typeof(TRepository).UnderlyingSystemType.GetInterfaces().FirstOrDefault()?.GetMethods().Where(x => x.Name == "Create" && !x.ReturnType.IsGenericTypeDefinition).FirstOrDefault();
                var response = method.Invoke(_repository, new object[] { newEntry });

                _unitOfWork.SaveChanges();

                _unitOfWork.Commit();

                var id = newEntry?.GetType().GetProperty("Id")?.GetValue(newEntry);

                newDTO?.GetType().GetProperty("Id")?.SetValue(newDTO, id);

                return (TDTO)newDTO;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }
        }

        private void SetCreationValues(DataSession dataSession, object? newEntry)
        {
            var entryType = newEntry?.GetType();

            entryType.GetProperty("CreationUserId")?.SetValue(newEntry, dataSession.Id);
            entryType.GetProperty("CreationDate")?.SetValue(newEntry, DateTime.Now);
        }

        public abstract void DTOValidationProcess(TDTO dto);

        public abstract void ViewModelValidationProcess(TInputCreateViewModel viewModel);
    }
}
