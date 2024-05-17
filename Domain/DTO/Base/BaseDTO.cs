namespace Domain.DTO.Base
{
    public class BaseDTO
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreationUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public long? ChangeUserId { get; set; }

        public UserDTO CreationUser { get; set; }
        public UserDTO? ChangeUser { get; set; }
    }
}
