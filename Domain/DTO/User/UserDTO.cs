using Domain.DTO.Base;

namespace Domain.DTO
{
    public class UserDTO : BaseDTO
    {
        public UserDTO() { }

        public UserDTO(string name, string email, string privateEmail, string password, DateTime bindingDate, string rA)
        {
            Name = name;
            Email = email;
            PrivateEmail = privateEmail;
            Password = password;
            BindingDate = bindingDate;
            RA = rA;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PrivateEmail { get; private set; }
        public string Password { get; private set; }
        public DateTime BindingDate { get; private set; }
        public string RA { get; private set; }

        #region VirtualProperties
        #region External
        public List<UserDTO>? ListCreationUser { get; private set; }
        public List<UserDTO>? ListChangeUser { get; private set; }
        public List<RoleDTO>? ListRoleCreationUser { get; private set; }
        public List<RoleDTO>? ListRoleChangeUser { get; private set; }
        public List<UserRoleDTO>? ListUserRole { get; private set; }
        public List<UserRoleDTO>? ListUserRoleCreationUser { get; private set; }
        #endregion
        #endregion
    }
}
