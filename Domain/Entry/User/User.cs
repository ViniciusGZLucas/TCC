using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entry
{
    public class User : BaseEntry
    {
        public User() { }

        public User(string name, string email, string privateEmail, string password, DateTime bindingDate)
        {
            Name = name;
            Email = email;
            PrivateEmail = privateEmail;
            Password = password;
            BindingDate = bindingDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PrivateEmail { get; set; }
        public string Password { get; set; }
        public DateTime BindingDate { get; set; }

        #region NotMapped
        [NotMapped]
        public override long CreationUserId { get => base.CreationUserId; set => base.CreationUserId = value; }
        [NotMapped]
        public override User CreationUser { get => base.CreationUser; set => base.CreationUser = value; }
        #endregion

        #region VirtualProperties
        #region External
        public virtual List<User> ListChangeUser { get; set; }

        #region Role
        public virtual List<Role> ListRoleCreationUser { get; set; }
        public virtual List<Role> ListRoleChangeUser { get; set; }
        public virtual List<UserRole> ListUserRole { get; set; }
        public virtual List<UserRole> ListUserRoleCreationUser { get; set; }
        #endregion

        #region Article
        public virtual List<Article> ListArticleCreationUser { get; set; }
        public virtual List<Article> ListArticleChangeUser { get; set; }
        public virtual List<Article> ListArticleAuthor { get; set; }
        #endregion

        #region ArticleDocument
        public virtual List<ArticleDocument> ListArticleDocumentCreationUser { get; set; }
        public virtual List<ArticleDocument> ListArticleDocumentChangeUser { get; set; }
        #endregion

        #region ArticleSchedule
        public virtual List<ArticleSchedule> ListArticleScheduleCreationUser { get; set; }
        #endregion

        #region Advisor
        public virtual List<Advisor> ListAdvisorCreationUser { get; set; }
        public virtual List<Advisor> ListAdvisorChangeUser { get; set; }
        #endregion

        #region Course
        public virtual List<Course> ListCourseCreationUser { get; set; }
        public virtual List<Course> ListCourseChangeUser { get; set; }
        #endregion
        #endregion
        #endregion
    }
}
