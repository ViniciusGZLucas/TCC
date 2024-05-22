using Domain.Entry;
using Domain.Interface.Repository.Base;
using Domain.ViewModel;

namespace Domain.Interface.Repository
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        List<CourseGridViewModel> GetAll();
    }
}
