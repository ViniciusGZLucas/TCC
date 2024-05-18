using Domain.DTO;
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

        public ArticleDTO? GetByAuthorId(long authorId) => _dbSet.Select(x => new ArticleDTO
        {
            Id = x.Id,
            CreationDate = x.CreationDate,
            CreationUserId = x.CreationUserId,
            ChangeDate = x.ChangeDate,
            ChangeUserId = x.ChangeUserId,
            Title = x.Title,
            Description = x.Description,
            AdvisorCurriculumLink = x.AdvisorCurriculumLink,
            CoAdvisorCurriculumLink = x.CoAdvisorCurriculumLink,
            AuthorId = x.AuthorId,
            AdvisorId = x.AdvisorId,
            CoAdvisorId = x.CoAdvisorId,
            DevolutionDate = x.DevolutionDate

        }).FirstOrDefault(x => x.AuthorId == authorId);
    }
}
