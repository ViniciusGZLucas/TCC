namespace CrossCutting.Services.TokenService
{
    public class PopulateToken
    {
        public PopulateToken(bool admin, IList<string> roles)
        {
            Admin = admin;
            Roles = roles;
        }

        public bool Admin { get; set; }
        public IList<string> Roles { get; set; }
    }
}
