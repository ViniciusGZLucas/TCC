using Domain.DTO.Base;

namespace Domain.DTO
{
    public class UserRoleDTO : BaseDTO
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }

        #region VirtualProperties
        #region Internal
        public UserDTO User { get; set; }
        public RoleDTO Role { get; set; }
        #endregion
        #endregion
    }
}
