namespace Domain.Entry
{
    public class Role : BaseEntry
    {
        public Role(string name, bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
        }

        public string Name { get; private set; }
        public bool IsAdmin { get; private set; }

        #region VirtualProperties
        #region External
        public virtual List<UserRole> ListUserRole { get; private set; }
        #endregion
        #endregion
    }
}
