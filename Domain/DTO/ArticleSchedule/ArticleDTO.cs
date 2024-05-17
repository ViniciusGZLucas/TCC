using Domain.DTO.Base;

namespace Domain.DTO
{
    public class ArticleScheduleDTO : BaseDTO
    {
        public ArticleScheduleDTO() { }

        public long ArticleId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        #region VirtualPropeties
        #region Internal
        public ArticleDTO Article { get; set; }
        #endregion
        #endregion
    }
}
