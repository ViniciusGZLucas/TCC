using Domain.ViewModel.Base;

namespace Domain.ViewModel
{
    public class ArticleViewModel : BaseViewModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? File { get; set; }
        public long? AuthorId { get; set; }
        public long? AdvisorId { get; set; }
        public long? CoAdvisorId { get; set; }
    }
}
