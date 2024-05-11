namespace CrossCutting.Services.TokenService
{
    public class PopulateToken
    {
        public PopulateToken(long id, string name, string email, string privateEmail, bool admin, IList<string> roles)
        {
            Id = id;
            Name = name;
            Email = email;
            PrivateEmail = privateEmail;
            Admin = admin;
            Roles = roles;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PrivateEmail { get; set; }
        public bool Admin { get; set; }
        public IList<string> Roles { get; set; }
    }
}
