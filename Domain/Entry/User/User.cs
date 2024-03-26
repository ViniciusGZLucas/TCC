namespace Domain.Entry
{
    public class User : BaseEntry
    {
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        #region VirtualProperties
        #region External
        public virtual List<User> ListCreationUser { get; private set; }
        public virtual List<User> ListChangeUser { get; private set; }
        public virtual List<Role> ListRoleCreationUser { get; private set; }
        public virtual List<Role> ListRoleChangeUser { get; private set; }
        public virtual List<UserRole> ListUserRole { get; private set; }
        public virtual List<UserRole> ListUserRoleCreationUser { get; private set; }
        #endregion
        #endregion
    }
}
