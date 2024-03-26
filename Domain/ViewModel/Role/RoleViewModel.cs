using Domain.ViewModel.Base;

namespace Domain.ViewModel
{
    public class RoleViewModel : BaseViewModel
    {
        public string? Name { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
