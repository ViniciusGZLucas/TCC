using Domain.Entry;
using Domain.Interface.Repository.Base;
using Domain.ViewModel;

namespace Domain.Interface.Repository
{
    public interface IArticleDocumentRepository : IBaseRepository<ArticleDocument>
    {
        List<ArticleDocumentViewModel> GetByArticleId(long articleId);
    }
}
