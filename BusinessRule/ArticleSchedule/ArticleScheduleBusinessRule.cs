using BusinessRule.Base;
using CrossCutting.DataSession;
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

        public new ArticleScheduleDTO Create(DataSession dataSession, InputCreateArticleScheduleViewModel viewModel)
        {
            if (viewModel.Date == null) throw new Exception("Necessário preencher data da entrega");
            if (string.IsNullOrEmpty(viewModel.Description)) throw new Exception("Necessário preencher descrição da entrega");

            return base.Create(dataSession, viewModel);
        }

        public override void DTOValidationProcess(ArticleScheduleDTO dto)
        {

        }

        public override void ViewModelValidationProcess(InputCreateArticleScheduleViewModel viewModel)
        {

        }

        public void Delete(DataSession dataSession, long id)
        {
            if (!dataSession.IsAdmin)
                throw new Exception("Apenas Administradores podem usar esse metodo");

            var articleSchedule = _repository.FindById(id);

            _unitOfWork.StartTransaction();

            if (articleSchedule != null)
                _repository.Delete(articleSchedule);

            _unitOfWork.Commit();
        }
    }
}
