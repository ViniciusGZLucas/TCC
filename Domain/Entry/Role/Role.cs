﻿namespace Domain.Entry
{
    public class Role : BaseEntry
    {
        public Role(string name, bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
        }

        public string Name { get; set; }
        public bool IsAdmin { get; set; }

        #region VirtualProperties
        #region External
        public virtual List<UserRole> ListUserRole { get; set; }
        #endregion
        #endregion
    }
}
