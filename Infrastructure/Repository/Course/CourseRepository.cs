using Domain.Entry;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(IctDbContext context) : base(context)
        {
        }

        public List<CourseGridViewModel> GetAll()
        {
            return (from i in _context.Courses
                    select new CourseGridViewModel
                    {
                        Id = i.Id,
                        Name = i.Name
                    }).ToList();
        }
    }
}
