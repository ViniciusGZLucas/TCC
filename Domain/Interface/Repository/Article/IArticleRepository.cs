using Domain.DTO;
using Domain.Entry;
using Domain.Interface.Repository.Base;
using Domain.ViewModel.Article;

namespace Domain.Interface.Repository
{
    public interface IArticleRepository : IBaseRepository<Article>
    {
        ArticleDTO? GetByAuthorId(long authorId);
        IList<ArticleGridViewModel> GetAll();
    }
}
