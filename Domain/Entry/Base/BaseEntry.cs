namespace Domain.Entry
{
    public abstract class BaseEntry
    {
        public long Id { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual long CreationUserId {  get; set; }
        public virtual DateTime? ChangeDate { get; set; }
        public virtual long? ChangeUserId { get; set; }

        public virtual User CreationUser { get; set; }
        public virtual User? ChangeUser { get; set; }

        public void PopulateBaseProperties(long id, DateTime creationDate, long creationUserId, DateTime? changeDate, long? changeUserId, User creationUser, User? changeUser)
        {
            Id = id;
            CreationDate = creationDate;
            CreationUserId = creationUserId;
            ChangeDate = changeDate;
            ChangeUserId = changeUserId;
            CreationUser = creationUser;
            ChangeUser = changeUser;
        }
    }
}
