using BusinessRule.Base;
using CrossCutting.DataSession;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;

namespace BusinessRule
{
    public class ArticleBusinessRule : BaseBusinessRule<IArticleRepository, ArticleDTO, ArticleViewModel, object>, IArticleBusinessRule
    {
        public ArticleBusinessRule(IArticleRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public override void DTOValidationProcess(ArticleDTO dto)
        {
        }

        public override void ViewModelValidationProcess(object viewModel)
        {
        }
    }
}
