using BusinessRule.Base;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;

namespace BusinessRule
{
    public class UserBusinessRule : BaseBusinessRule<IUserRepository, UserDTO, UserViewModel>, IUserBusinessRule
    {
        public UserBusinessRule(IUserRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public UserDTO Create(UserViewModel viewModel)
        {
            _unitOfWork.StartTransaction();

            UserDTO dto = default;

            try
            {
                //Validação Via ViewModel

                base.Create(viewModel);

                //Validação Via DTO
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw new Exception(ex.Message);
            }

            return dto;
        }
    }
}
