using Domain.Entry;
using Domain.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class ArticleDocumentRepository : BaseRepository<ArticleDocument>, IArticleDocumentRepository
    {
        public ArticleDocumentRepository(IctDbContext context) : base(context)
        {
        }
    }
}
