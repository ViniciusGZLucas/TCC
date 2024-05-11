using Domain.DTO.Base;
using Domain.Entry;

namespace Domain.DTO
{
    public class ArticleDTO : BaseDTO
    {
        public ArticleDTO() { }

        public ArticleDTO(string title, string description, string advisorCurriculumLink, string coAdvisorCurriculumLink, string file, long authorId, long advisorId, long coAdvisorId, User author, User advisor, User coAdvisor, DateTime devolutionDate)
        {
            Title = title;
            Description = description;
            AdvisorCurriculumLink = advisorCurriculumLink;
            CoAdvisorCurriculumLink = coAdvisorCurriculumLink;
            File = file;
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
        public string CoAdvisorCurriculumLink { get; set; }
        public string File { get; set; }
        public long AuthorId { get; set; }
        public long AdvisorId { get; set; }
        public long CoAdvisorId { get; set; }
        public DateTime DevolutionDate { get; set; }

        #region VirtualPropeties
        #region Internal
        public User Author { get; set; }
        public User Advisor { get; set; }
        public User CoAdvisor { get; set; }
        #endregion
        #endregion
    }
}
