using BusinessRule.Base;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule.ArticleSchedule;
using Domain.Interface.Repository;
using Domain.ViewModel;

namespace BusinessRule
{
    public class ArticleScheduleBusinessRule : BaseBusinessRule<IArticleScheduleRepository, ArticleScheduleDTO, ArticleScheduleViewModel, InputCreateArticleScheduleViewModel>, IArticleScheduleBusinessRule
    {
        public ArticleScheduleBusinessRule(IArticleScheduleRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public override void DTOValidationProcess(ArticleScheduleDTO dto)
        {

        }

        public override void ViewModelValidationProcess(InputCreateArticleScheduleViewModel viewModel)
        {

        }
    }
}
