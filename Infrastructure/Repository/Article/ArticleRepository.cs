using Domain.DTO;
using Domain.Entry;
using Domain.Interface.Repository;
using Domain.ViewModel.Article;
using Infrastructure.Context;
using Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(IctDbContext context) : base(context)
        {
        }

        public IList<ArticleGridViewModel> GetAll()
        {
            return _dbSet.Include(x => x.Advisor).Include(x => x.Author).Select(x => new ArticleGridViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author.Name,
                Advisor = x.Advisor.Name
            }).ToList();
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
            AuthorId = x.AuthorId,
            AdvisorId = x.AdvisorId,
            CoAdvisorId = x.CoAdvisorId,
            DevolutionDate = x.DevolutionDate

        }).FirstOrDefault(x => x.AuthorId == authorId);
    }
}
