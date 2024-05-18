using Domain.Entry;
using Domain.Interface.Repository.Base;

namespace Domain.Interface.Repository
{
    public interface IArticleScheduleRepository : IBaseRepository<ArticleSchedule>
    {
        IList<ArticleSchedule>? GetByArticleId(long articleId);
    }
}
