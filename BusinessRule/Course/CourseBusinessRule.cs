using BusinessRule.Base;
using CrossCutting.DataSession;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;

namespace BusinessRule
{
    public class CourseBusinessRule : BaseBusinessRule<ICourseRepository, CourseDTO, CourseViewModel, InputCreateCourseViewModel>, ICourseBusinessRule
    {
        public CourseBusinessRule(ICourseRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public CourseDTO Create(DataSession dataSession, InputCreateCourseViewModel viewModel)
        {
            var dto = base.Create(dataSession, viewModel);

            return dto;
        }

        public override void DTOValidationProcess(CourseDTO dto)
        {
        }

        public override void ViewModelValidationProcess(InputCreateCourseViewModel viewModel)
        {
        }

        public List<CourseGridViewModel> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
