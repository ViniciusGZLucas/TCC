using BusinessRule.Base;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;

namespace BusinessRule
{
    public class UserRoleBusinessRule : BaseBusinessRule<IUserRoleRepository, UserRoleDTO, UserRoleViewModel>, IUserRoleBusinessRule
    {
        public UserRoleBusinessRule(IUserRoleRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public override void DTOValidationProcess(UserRoleDTO dto)
        {
            
        }

        public override void ViewModelValidationProcess(UserRoleViewModel viewModel)
        {
            
        }
    }
}
