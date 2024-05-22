using Domain.Entry;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class ArticleDocumentRepository : BaseRepository<ArticleDocument>, IArticleDocumentRepository
    {
        public ArticleDocumentRepository(IctDbContext context) : base(context)
        {
        }

        public List<ArticleDocumentViewModel> GetByArticleId(long articleId)
        {
            return (from i in _dbSet
                    where i.ArticleId == articleId
                    select new ArticleDocumentViewModel
                    {
                        Id = i.ArticleId,
                        CreationUserId = i.CreationUserId,
                        CreationDate = i.CreationDate,
                        ChangeUserId = i.ChangeUserId,
                        ChangeDate = i.ChangeDate,
                        FileName = i.FileName,
                        ArticleId = i.ArticleId,
                        Base64File = i.Base64File
                    }).ToList();
        }
    }
}
