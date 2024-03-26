using Domain.DTO.Base;
using Domain.Entry;

namespace Domain.DTO
{
    public class UserDTO : BaseDTO
    {
        public UserDTO() { }

        public UserDTO(string name, string email, string password)
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
        public List<User>? ListCreationUser { get; private set; }
        public List<User>? ListChangeUser { get; private set; }
        public List<Role>? ListRoleCreationUser { get; private set; }
        public List<Role>? ListRoleChangeUser { get; private set; }
        public List<UserRole>? ListUserRole { get; private set; }
        public List<UserRole>? ListUserRoleCreationUser { get; private set; }
        #endregion
        #endregion
    }
}
