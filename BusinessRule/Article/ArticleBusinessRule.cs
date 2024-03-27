using Domain.Interface.BusinessRule;
using BusinessRule.Base;
using Domain.Interface.Repository;
using Domain.DTO;
using Domain.ViewModel;
using Domain.Interface;

namespace BusinessRule
{
    public class ArticleBusinessRule : BaseBusinessRule<IArticleRepository, ArticleDTO, ArticleViewModel>, IArticleBusinessRule
    {
        public ArticleBusinessRule(IArticleRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public ArticleDTO Create(ArticleViewModel viewModel)
        {
            var dto = base.Create(viewModel);
           
            return dto;
        }

        public override void DTOValidationProcess(ArticleDTO dto)
        {
        }

        public override void ViewModelValidationProcess(ArticleViewModel viewModel)
        {
        }
    }
}
