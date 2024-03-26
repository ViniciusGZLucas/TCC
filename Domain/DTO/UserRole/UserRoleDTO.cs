using Domain.DTO.Base;
using Domain.Entry;

namespace Domain.DTO
{
    public class UserRoleDTO : BaseDTO
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }

        #region VirtualProperties
        #region Internal
        public User User { get; set; }
        public Role Role { get; set; }
        #endregion
        #endregion
    }
}
