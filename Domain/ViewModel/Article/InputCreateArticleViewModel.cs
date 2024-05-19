namespace Domain.ViewModel.Article
{
    public class InputCreateArticleViewModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public long? AuthorId { get; set; }
        public long? AdvisorId { get; set; }
        public long? CoAdvisorId { get; set; }
        public DateTime? DevolutionDate { get; set; }
    }
}
