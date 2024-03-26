using Domain.DTO.Base;
using Domain.Entry;

namespace Domain.DTO
{
    public class RoleDTO : BaseDTO
    {
        public RoleDTO(string name, bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
        }

        public string Name { get; set; }
        public bool IsAdmin { get; set; }

        #region VirtualProperties
        #region External
        public List<UserRole>? ListUserRole { get; set; }
        #endregion
        #endregion
    }
}
