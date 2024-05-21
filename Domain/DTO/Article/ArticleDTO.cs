using Domain.DTO.Base;

namespace Domain.DTO
{
    public class ArticleDTO : BaseDTO
    {
        public ArticleDTO() { }

        public ArticleDTO(string title, string description, long authorId, long advisorId, long? coAdvisorId, UserDTO author, UserDTO advisor, UserDTO? coAdvisor, DateTime devolutionDate, bool isAccepted)
        {
            Title = title;
            Description = description;
            AuthorId = authorId;
            AdvisorId = advisorId;
            CoAdvisorId = coAdvisorId;
            Author = author;
            Advisor = advisor;
            CoAdvisor = coAdvisor;
            DevolutionDate = devolutionDate;
            IsAccepted = isAccepted;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public long AuthorId { get; set; }
        public long AdvisorId { get; set; }
        public long? CoAdvisorId { get; set; }
        public DateTime DevolutionDate { get; set; }
        public bool IsAccepted { get; set; }

        #region VirtualPropeties
        #region Internal
        public UserDTO Author { get; set; }
        public UserDTO Advisor { get; set; }
        public UserDTO CoAdvisor { get; set; }
        #endregion
        #endregion
    }
}
