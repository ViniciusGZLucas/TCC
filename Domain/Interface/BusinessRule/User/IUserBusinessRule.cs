using CrossCutting.DataSession;
using Domain.DTO;
using Domain.ViewModel.User;

namespace Domain.Interface.BusinessRule
{
    public interface IUserBusinessRule
    {
        UserDTO Create(DataSession dataSession, InputCreateUserViewModel viewModel);
        UserTokenViewModel Login(string email, string password);
    }
}
