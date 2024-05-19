namespace Domain.Entry
{
    public class Article : BaseEntry
    {
        public Article() { }

        public Article(string title, string description, long authorId, long advisorId, long? coAdvisorId)
        {
            Title = title;
            Description = description;
            AuthorId = authorId;
            AdvisorId = advisorId;
            CoAdvisorId = coAdvisorId;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public long AuthorId { get; set; }
        public long AdvisorId { get; set; }
        public long? CoAdvisorId { get; set; }
        public DateTime DevolutionDate { get; set; }

        #region VirtualPropeties
        #region Internal
        public virtual User Author { get; set; }
        public virtual Advisor Advisor { get; set; }
        public virtual Advisor? CoAdvisor { get; set; }
        #endregion
        #region External
        public virtual List<ArticleDocument> ListArticleDocuments { get; set; }
        public virtual List<ArticleSchedule> ListArticleSchedule { get; set; }
        #endregion
        #endregion
    }
}
