using Domain.ViewModel.Base;

namespace Domain.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RA { get; set; }
    }
}
