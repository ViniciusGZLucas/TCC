using Domain.Entry;
using Domain.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class ArticleScheduleRepository : BaseRepository<ArticleSchedule>, IArticleScheduleRepository
    {
        public ArticleScheduleRepository(IctDbContext context) : base(context)
        {
        }
    }
}
