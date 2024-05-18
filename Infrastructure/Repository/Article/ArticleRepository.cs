using Domain.Entry;
using Domain.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(IctDbContext context) : base(context)
        {
        }

        public Article? GetByAuthorId(long authorId) => _dbSet.FirstOrDefault(x => x.AuthorId == authorId);
    }
}
