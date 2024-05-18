namespace Domain.Entry
{
    public class Article : BaseEntry
    {
        public Article() { }

        public Article(string title, string description, string advisorCurriculumLink, string? coAdvisorCurriculumLink, string file, long authorId, long advisorId, long? coAdvisorId)
        {
            Title = title;
            Description = description;
            AdvisorCurriculumLink = advisorCurriculumLink;
            CoAdvisorCurriculumLink = coAdvisorCurriculumLink;
            AuthorId = authorId;
            AdvisorId = advisorId;
            CoAdvisorId = coAdvisorId;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string AdvisorCurriculumLink { get; set; }
        public string? CoAdvisorCurriculumLink { get; set; }
        public long AuthorId { get; set; }
        public long AdvisorId { get; set; }
        public long? CoAdvisorId { get; set; }
        public DateTime DevolutionDate { get; set; }

        #region VirtualPropeties
        #region Internal
        public virtual User Author { get; set; }
        public virtual User Advisor { get; set; }
        public virtual User? CoAdvisor { get; set; }
        #endregion
        #region External
        public virtual List<ArticleDocument> ListArticleDocuments { get; set; }
        public virtual List<ArticleSchedule> ListArticleSchedule { get; set; }
        #endregion
        #endregion
    }
}
