using Domain.ViewModel.Base;

namespace Domain.ViewModel
{
    public class UserRoleViewModel : BaseViewModel
    {
        public long? UserId { get; set; }
        public long? RoleId { get; set; }
    }
}
