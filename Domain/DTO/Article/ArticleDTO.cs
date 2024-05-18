using Domain.DTO.Base;
using Domain.Entry;

namespace Domain.DTO
{
    public class ArticleDTO : BaseDTO
    {
        public ArticleDTO() { }

        public ArticleDTO(string title, string description, string advisorCurriculumLink, string? coAdvisorCurriculumLink, long authorId, long advisorId, long? coAdvisorId, UserDTO author, UserDTO advisor, UserDTO? coAdvisor, DateTime devolutionDate)
        {
            Title = title;
            Description = description;
            AdvisorCurriculumLink = advisorCurriculumLink;
            CoAdvisorCurriculumLink = coAdvisorCurriculumLink;
            AuthorId = authorId;
            AdvisorId = advisorId;
            CoAdvisorId = coAdvisorId;
            Author = author;
            Advisor = advisor;
            CoAdvisor = coAdvisor;
            DevolutionDate = devolutionDate;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string AdvisorCurriculumLink { get; set; }
        public string? CoAdvisorCurriculumLink { get; set; }
        public long AuthorId { get; set; }
        public long AdvisorId { get; set; }
        public long? CoAdvisorId { get; set; }
        public DateTime DevolutionDate { get; set; }

        #region VirtualPropeties
        #region Internal
        public UserDTO Author { get; set; }
        public UserDTO Advisor { get; set; }
        public UserDTO CoAdvisor { get; set; }
        #endregion
        #endregion
    }
}
