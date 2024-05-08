using CrossCutting.Services.TokenService;

namespace Domain.ViewModel.User
{
    public class UserTokenViewModel
    {
        public UserTokenViewModel(string? token, PopulateToken? tokenInfos)
        {
            Token = token;
            TokenInfos = tokenInfos;
        }

        public string? Token { get; set; }
        public PopulateToken? TokenInfos { get; set; }
    }
}
