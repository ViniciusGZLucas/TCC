using Microsoft.AspNetCore.Http;

namespace Domain.ViewModel.Article
{
    public class InputLinkArticleDocumentViewModel
    {
        public InputLinkArticleDocumentViewModel(long id, IFormFile? formFile)
        {
            Id = id;
            FormFile = formFile;
        }

        public long Id { get; set; }
        public IFormFile? FormFile { get; set; }
    }
}
