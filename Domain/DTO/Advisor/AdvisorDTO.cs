using Domain.DTO.Base;

namespace Domain.DTO
{
    public class AdvisorDTO : BaseDTO
    {
        public AdvisorDTO() { }

        public AdvisorDTO(string name, string curriculumLink, long courseId)
        {
            Name = name;
            CurriculumLink = curriculumLink;
            CourseId = courseId;
        }

        public string Name { get; set; }
        public string CurriculumLink { get; set; }
        public long CourseId { get; set; }
    }
}
