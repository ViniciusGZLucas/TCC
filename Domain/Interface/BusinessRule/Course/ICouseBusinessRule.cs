using CrossCutting.DataSession;
using Domain.DTO;
using Domain.ViewModel;

namespace Domain.Interface.BusinessRule
{
    public interface ICourseBusinessRule
    {
        CourseDTO Create(DataSession dataSession, InputCreateCourseViewModel viewModel);
    }
}
