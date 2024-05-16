using BusinessRule.Base;
using CrossCutting.DataSession;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Domain.ViewModel.Article;
using Domain.ViewModel.User;

namespace BusinessRule
{
    public class ArticleBusinessRule : BaseBusinessRule<IArticleRepository, ArticleDTO, ArticleViewModel, InputCreateArticleViewModel>, IArticleBusinessRule
    {
        public ArticleBusinessRule(IArticleRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public ArticleDTO Create(DataSession dataSession, InputCreateArticleViewModel viewModel)
        {
            var dto = base.Create(dataSession, viewModel);

            return dto;
        }

        public override void DTOValidationProcess(ArticleDTO dto)
        {
        }

        public override void ViewModelValidationProcess(InputCreateArticleViewModel viewModel)
        {
        }

        public void LinkDocument(DataSession dataSession, InputLinkArticleDocumentViewModel viewModel)
        {

        }
    }
}
