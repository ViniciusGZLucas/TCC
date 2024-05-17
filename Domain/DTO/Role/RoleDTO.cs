using Domain.DTO.Base;

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
        public List<UserRoleDTO>? ListUserRole { get; set; }
        #endregion
        #endregion
    }
}
