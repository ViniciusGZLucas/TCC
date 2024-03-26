using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entry
{
    public class UserRole : BaseEntry
    {
        public UserRole(long userId, long roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }

        public long UserId { get; set; }
        public long RoleId { get; set; }

        #region NotMapped
        [NotMapped]
        public override DateTime? ChangeDate => base.ChangeDate;
        [NotMapped]
        public override long? ChangeUserId => base.ChangeUserId;
        [NotMapped]
        public override User? ChangeUser => base.ChangeUser;
        #endregion

        #region VirtualProperties
        #region Internal
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        #endregion
        #endregion
    }
}
