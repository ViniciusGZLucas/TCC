using Domain.DTO.Base;

namespace Domain.DTO
{
    public class CourseDTO : BaseDTO
    {
        public CourseDTO() { }

        public CourseDTO(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
