using Domain.ViewModel.Base;

namespace Domain.ViewModel
{
    public class AdvisorViewModel : BaseViewModel
    {
        public string? Name { get; set; }
        public string? CurriculumLink { get; set; }
        public long? CourseId { get; set; }
    }
}
