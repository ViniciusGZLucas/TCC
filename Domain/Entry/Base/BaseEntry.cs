namespace Domain.Entry
{
    public abstract class BaseEntry
    {
        public virtual long Id { get; private set; }
        public virtual DateTime CreationDate { get; private set; }
        public virtual long CreationUserId {  get; private set; }
        public virtual DateTime? ChangeDate { get; private set; }
        public virtual long? ChangeUserId { get; private set; }

        public virtual User CreationUser { get; private set; }
        public virtual User? ChangeUser { get; private set; }

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
