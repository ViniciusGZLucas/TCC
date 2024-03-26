using Domain.DTO;
using Domain.ViewModel;

namespace Domain.Interface.BusinessRule
{
    public interface IUserBusinessRule
    {
        UserDTO Create(UserViewModel viewModel);
    }
}
