namespace Domain.ViewModel.Base
{
    public class BaseViewModel
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreationUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public long? ChangeUserId { get; set; }
    }
}
