using BusinessRule.Base;
using CrossCutting.Services.TokenService;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Domain.ViewModel.User;

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

        public UserTokenViewModel Login(string email, string password)
        {
            var user = _repository.GetByEmail(email);

            if (user == null || user.Password != password)
                throw new Exception("Email ou Senha Invalidos");

            var roles = _repository.GetRolesByUser(user.Id);

            var populateToken = new PopulateToken(user.Name, user.Email, user.PrivateEmail, roles?.Any(x => x.IsAdmin) ?? false, roles?.Select(x => x.Name).ToList());

            var token = TokenService.GenerateToken(populateToken);

            return new UserTokenViewModel(token, populateToken);
        }
    }
}
