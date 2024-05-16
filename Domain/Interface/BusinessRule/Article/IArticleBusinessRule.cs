using CrossCutting.DataSession;
using Domain.DTO;
using Domain.ViewModel.Article;

namespace Domain.Interface.BusinessRule
{
    public interface IArticleBusinessRule
    {
        ArticleDTO Create(DataSession dataSession, InputCreateArticleViewModel viewModel);
        void LinkDocument(DataSession dataSession, InputLinkArticleDocumentViewModel viewModel);
    }
}
