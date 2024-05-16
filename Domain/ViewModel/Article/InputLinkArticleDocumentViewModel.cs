using Microsoft.AspNetCore.Http;

namespace Domain.ViewModel.Article
{
    public class InputLinkArticleDocumentViewModel
    {
        public long? Id { get; set; }
        public IFormFile? FormFile { get; set; }
    }
}
