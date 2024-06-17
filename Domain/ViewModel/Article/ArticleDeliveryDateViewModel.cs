namespace Domain.ViewModel.Article
{
    public class ArticleDeliveryDateViewModel
    {
        public long? Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Advisor { get; set; }
        public string? CoAdvisor { get; set; }
        public string? Description { get; set; }
        public string? AdvisorCurriculumLink { get; set; }
        public string? CoAdvisorCurriculumLink { get; set; }
        public string? File { get; set; }
        public long? AuthorId { get; set; }
        public long? AdvisorId { get; set; }
        public long? CoAdvisorId { get; set; }
        public bool? IsAccepted { get; set; }
        public IList<ArticleScheduleViewModel>? DeliveryDates { get; set; }
        public IList<ArticleDocumentViewModel>? ListArticleDocument { get; set; }
    }
}
