namespace Domain.Entry
{
    public class Advisor : BaseEntry
    {
        public Advisor() { }

        public Advisor(string name, string curriculumLink, long courseId)
        {
            Name = name;
            CurriculumLink = curriculumLink;
            CourseId = courseId;
        }

        public string Name { get; set; }
        public string CurriculumLink { get; set; }
        public long CourseId { get; set; }

        #region Virtual Properties
        #region Internal
        public virtual Course Course { get; set; }
        #endregion
        #region External
        public virtual List<Article> ListArticleAdvisor { get; set; }
        public virtual List<Article> ListArticleCoAdvisor { get; set; }
        #endregion
        #endregion
    }
}
