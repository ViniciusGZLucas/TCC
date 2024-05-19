using CrossCutting.DataSession;
using Domain.DTO;
using Domain.ViewModel.Article;

namespace Domain.Interface.BusinessRule
{
    public interface IArticleBusinessRule
    {
        ArticleDTO Create(DataSession dataSession, InputCreateArticleViewModel viewModel);
        IList<ArticleGridViewModel>? GetAll(DataSession dataSession);
        ArticleDeliveryDateViewModel? GetByAuthorId(DataSession dataSession);
        ArticleDeliveryDateViewModel? GetById(DataSession dataSession, long articleId);
        void LinkDocument(DataSession dataSession, InputLinkArticleDocumentViewModel viewModel);
        void Delete(DataSession dataSession, long id);
    }
}
