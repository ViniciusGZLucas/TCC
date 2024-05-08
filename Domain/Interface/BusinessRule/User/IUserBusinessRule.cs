using CrossCutting.Services.TokenService;
using Domain.DTO;
using Domain.ViewModel;
using Domain.ViewModel.User;

namespace Domain.Interface.BusinessRule
{
    public interface IUserBusinessRule
    {
        UserDTO Create(UserViewModel viewModel);
        UserTokenViewModel Login(string email, string password);
    }
}
