namespace Domain.Entry
{
    public class ArticleSchedule : BaseEntry
    {
        public ArticleSchedule() { }

        public ArticleSchedule(long articleId, string description, DateTime date)
        {
            ArticleId = articleId;
            Description = description;
            Date = date;
        }

        public long ArticleId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        #region VirtualProperties
        #region Internal
        public virtual Article Article { get; set; }
        #endregion
        #endregion
    }
}
