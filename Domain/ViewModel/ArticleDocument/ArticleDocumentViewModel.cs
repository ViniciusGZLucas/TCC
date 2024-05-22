using Domain.ViewModel.Base;

namespace Domain.ViewModel
{
    public class ArticleDocumentViewModel : BaseViewModel
    {
        public long? ArticleId { get; set; }
        public string? FileName { get; set; }
        public string? Base64File { get; set; }
    }
}
