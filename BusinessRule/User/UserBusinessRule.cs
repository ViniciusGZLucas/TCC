using BusinessRule.Base;
using CrossCutting.DataSession;
using CrossCutting.Services.TokenService;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Domain.ViewModel.User;

namespace BusinessRule
{
    public class UserBusinessRule : BaseBusinessRule<IUserRepository, UserDTO, UserViewModel, InputCreateUserViewModel>, IUserBusinessRule
    {
        public UserBusinessRule(IUserRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public UserDTO Create(DataSession dataSession, InputCreateUserViewModel viewModel)
        {
            var dto = base.Create(dataSession, viewModel);

            return dto;
        }

        public override void ViewModelValidationProcess(InputCreateUserViewModel viewModel)
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

            var populateToken = new PopulateToken(user.Id, user.Name, user.Email, user.PrivateEmail, roles?.Any(x => x.IsAdmin) ?? false, roles?.Select(x => x.Name).ToList());

            var token = TokenService.GenerateToken(populateToken);

            return new UserTokenViewModel(token, populateToken);
        }

        public UserViewModel GetLoggedUser(DataSession dataSession)
        {
            var entry = _repository.FindById(dataSession.Id);

            return new UserViewModel
            {
                Id = entry.Id,
                CreationDate = entry.CreationDate,
                CreationUserId = entry.CreationUserId,
                ChangeDate = entry.ChangeDate,
                ChangeUserId = entry.ChangeUserId,
                Name = entry.Name,
                Email = entry.Email
            };
        }
    }
}
