namespace Domain.Entry
{
    public class User : BaseEntry
    {
        public User() { }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        #region VirtualProperties
        #region External
        public virtual List<User> ListCreationUser { get; set; }
        public virtual List<User> ListChangeUser { get; set; }

        #region Role
        public virtual List<Role> ListRoleCreationUser { get; set; }
        public virtual List<Role> ListRoleChangeUser { get; set; }
        public virtual List<UserRole> ListUserRole { get; set; }
        public virtual List<UserRole> ListUserRoleCreationUser { get; set; }
        #endregion

        #region Article
        public virtual List<Article> ListArticleCreationUser { get; set; }
        public virtual List<Article> ListArticleChangeUser { get; set; }
        public virtual List<Article> ListArticleAuthor { get; set; }
        public virtual List<Article> ListArticleAdvisor { get; set; }
        public virtual List<Article> ListArticleCoAdvisor { get; set; }
        #endregion
        #endregion
        #endregion
    }
}
