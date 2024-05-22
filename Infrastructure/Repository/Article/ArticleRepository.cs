using Domain.DTO;
using Domain.Entry;
using Domain.Interface.Repository;
using Domain.ViewModel.Article;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(IctDbContext context) : base(context)
        {
        }

        public IList<ArticleGridViewModel> GetAll()
        {
            return (from article in _dbSet
                    join advisor in _context.Advisors on article.AdvisorId equals advisor.Id
                    join author in _context.Users on article.AuthorId equals author.Id
                    select new ArticleGridViewModel
                    {
                        Id = article.Id,
                        Title = article.Title,
                        Author = author.Name,
                        Advisor = advisor.Name,
                        IsAccepted = article.IsAccepted,
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
            DevolutionDate = x.DevolutionDate,
            IsAccepted = x.IsAccepted

        }).FirstOrDefault(x => x.AuthorId == authorId);
    }
}
