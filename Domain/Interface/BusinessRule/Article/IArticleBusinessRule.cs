using CrossCutting.DataSession;
using Domain.DTO;
using Domain.ViewModel.Article;

namespace Domain.Interface.BusinessRule
{
    public interface IArticleBusinessRule
    {
        ArticleDTO Create(DataSession dataSession, InputCreateArticleViewModel viewModel);
        List<ArticleDTO>? GetAll(DataSession dataSession);
        ArticleDTO? GetByAuthorId(DataSession dataSession);
        ArticleDTO? GetById(DataSession dataSession, long articleId);
        void LinkDocument(DataSession dataSession, InputLinkArticleDocumentViewModel viewModel);
    }
}
