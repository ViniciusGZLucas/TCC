using Domain.Interface;
using Domain.Interface.BusinessRule.Base;

namespace BusinessRule.Base
{
    public abstract class BaseBusinessRule<TRepository, TDTO, TViewModel> : IBaseBusinessRule<TRepository, TDTO, TViewModel>
    {
        protected readonly TRepository _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseBusinessRule(TRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public TDTO Create(TViewModel viewModel)
        {
            ViewModelValidationProcess(viewModel);

            var viewModelProperties = typeof(TViewModel).GetProperties();
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

            _unitOfWork.StartTransaction();

            try
            {
                var method = typeof(TRepository).UnderlyingSystemType.GetInterfaces().FirstOrDefault()?.GetMethods().Where(x => x.Name == "Create" && !x.ReturnType.IsGenericTypeDefinition).FirstOrDefault();
                method.Invoke(_repository, new object[] { newEntry });

                _unitOfWork.SaveChanges();

                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }

            return (TDTO)newDTO;
        }

        public abstract void DTOValidationProcess(TDTO dto);

        public abstract void ViewModelValidationProcess(TViewModel viewModel);
    }
}
