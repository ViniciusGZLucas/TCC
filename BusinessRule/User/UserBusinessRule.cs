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
            var dto = base.Create(viewModel);

            return dto;
        }

        public override void ViewModelValidationProcess(UserViewModel viewModel)
        {
        }

        public override void DTOValidationProcess(UserDTO dto)
        {
        }
    }
}
