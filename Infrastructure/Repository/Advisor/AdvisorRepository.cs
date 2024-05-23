using Domain.Entry;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Domain.ViewModel.Article;
using Infrastructure.Context;
using Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class AdvisorRepository : BaseRepository<Advisor>, IAdvisorRepository
    {
        public AdvisorRepository(IctDbContext context) : base(context)
        {
        }

        public IList<AdvisorGridViewModel> GetAll()
        {
            return (from i in _dbSet
                    join j in _context.Set<Course>() on i.CourseId equals j.Id
                    select new AdvisorGridViewModel
                    {
                        Id = i.Id,
                        Name = i.Name,
                        CurriculumLink = i.CurriculumLink,
                        CourseName = j.Name
                    }).ToList();
        }
    }
}
