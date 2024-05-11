using Domain.DTO.Base;
using Domain.Entry;

namespace Domain.DTO
{
    public class UserDTO : BaseDTO
    {
        public UserDTO() { }

        public UserDTO(string name, string email, string privateEmail, string password, DateTime bindingDate)
        {
            Name = name;
            Email = email;
            PrivateEmail = privateEmail;
            Password = password;
            BindingDate = bindingDate;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PrivateEmail { get; private set; }
        public string Password { get; private set; }
        public DateTime BindingDate { get; private set; }

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
