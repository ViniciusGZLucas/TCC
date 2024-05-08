namespace CrossCutting.Services.TokenService
{
    public class PopulateToken
    {
        public PopulateToken(string name, string email, string privateEmail, bool admin, IList<string> roles)
        {
            Name = name;
            Email = email;
            PrivateEmail = privateEmail;
            Admin = admin;
            Roles = roles;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PrivateEmail { get; set; }
        public bool Admin { get; set; }
        public IList<string> Roles { get; set; }
    }
}
