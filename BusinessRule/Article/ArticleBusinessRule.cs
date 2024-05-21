using BusinessRule.Base;
using CrossCutting.DataSession;
using Domain.DTO;
using Domain.Entry;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Domain.ViewModel.Article;

namespace BusinessRule
{
    public class ArticleBusinessRule : BaseBusinessRule<IArticleRepository, ArticleDTO, ArticleViewModel, InputCreateArticleViewModel>, IArticleBusinessRule
    {
        private readonly IArticleDocumentRepository _articleDocumentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IArticleScheduleRepository _articleScheduleRepository;
        private readonly IAdvisorRepository _advisorRepository;

        public ArticleBusinessRule(IArticleRepository repository, IUnitOfWork unitOfWork, IArticleDocumentRepository articleDocumentRepository, IUserRepository userRepository, IArticleScheduleRepository articleScheduleRepository, IAdvisorRepository advisorRepository) : base(repository, unitOfWork)
        {
            _articleDocumentRepository = articleDocumentRepository;
            _userRepository = userRepository;
            _articleScheduleRepository = articleScheduleRepository;
            _advisorRepository = advisorRepository;
        }

        public ArticleDTO Create(DataSession dataSession, InputCreateArticleViewModel viewModel)
        {
            if (_repository.GetByAuthorId(dataSession.Id) != null)
                throw new Exception("Usuário já possui um projeto cadastrado");

            viewModel.AuthorId = dataSession.Id;
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
            if (viewModel.Id == null || viewModel.Id < 0)
                throw new Exception("Id do artigo invalido");

            if (viewModel.FormFile == null)
                throw new Exception("Corpo do arquivo invalido");

            if (string.IsNullOrEmpty(viewModel.FormFile.FileName))
                throw new Exception("Nome do arquivo invalido");

            string base64String = String.Empty;

            using (var readStream = viewModel.FormFile?.OpenReadStream())
            {
                var buffer = new byte[readStream.Length];

                readStream?.Read(buffer);

                base64String = Convert.ToBase64String(buffer);
            }

            var articleDocumentEntry = new ArticleDocument(viewModel.Id.Value, viewModel.FormFile?.FileName, base64String);
            var creationUser = _userRepository.FindById(dataSession.Id);

            articleDocumentEntry.PopulateBaseProperties(0, DateTime.Now, dataSession.Id, null, null, creationUser, null);

            _unitOfWork.StartTransaction();
            _articleDocumentRepository.Create(articleDocumentEntry);
            _unitOfWork.Commit();
        }

        public IList<ArticleGridViewModel>? GetAll(DataSession dataSession)
        {
            if (!dataSession.IsAdmin)
                throw new Exception("Apenas Administradores podem usar esse metodo");

            return _repository.GetAll();
        }

        public ArticleDeliveryDateViewModel? GetByAuthorId(DataSession dataSession)
        {
            var article = _repository.GetByAuthorId(dataSession.Id);

            if (article == null)
                return default;

            if (article.AuthorId != dataSession.Id)
                return default;

            var advisor = _advisorRepository.FindById(article.AdvisorId);
            var author = _userRepository.FindById(article.AuthorId);
            var coAdvisor = _advisorRepository.FindById(article.CoAdvisorId ?? 0);

            var deliveryDates = _articleScheduleRepository.GetByArticleId(article.Id)?.Select(x => new ArticleScheduleViewModel
            {
                ArticleId = article.Id,
                Date = x.Date,
                Description = x.Description
            }).ToList();

            var articleDTO = new ArticleDeliveryDateViewModel
            {
                Id = article.Id,
                Title = article.Title,
                Description = article.Description,
                Advisor = advisor?.Name,
                Author = author?.Name,
                AdvisorCurriculumLink = advisor?.CurriculumLink,
                CoAdvisorCurriculumLink = coAdvisor?.CurriculumLink,
                AuthorId = article.AuthorId,
                AdvisorId = article.AdvisorId,
                CoAdvisorId = article.CoAdvisorId,
                DeliveryDates = deliveryDates
            };

            return articleDTO;
        }

        public ArticleDeliveryDateViewModel? GetById(DataSession dataSession, long articleId)
        {
            var article = _repository.FindById(articleId);

            if (article == null)
                return default;

            if (article.AuthorId != dataSession.Id && !dataSession.IsAdmin)
                return default;

            var advisor = _advisorRepository.FindById(article.AdvisorId);
            var author = _userRepository.FindById(article.AuthorId);
            var coAdvisor = _advisorRepository.FindById(article.CoAdvisorId ?? 0);

            var deliveryDates = _articleScheduleRepository.GetByArticleId(article.Id)?.Select(x => new ArticleScheduleViewModel
            {
                Id = x.Id,
                ArticleId = article.Id,
                Date = x.Date,
                Description = x.Description
            }).ToList();

            var articleDTO = new ArticleDeliveryDateViewModel
            {
                Id = article.Id,
                Title = article.Title,
                Author = author?.Name,
                Description = article.Description,
                Advisor = _advisorRepository.FindById(article.AdvisorId)?.Name,
                AdvisorCurriculumLink = advisor?.CurriculumLink,
                CoAdvisorCurriculumLink = coAdvisor?.CurriculumLink,
                AuthorId = article.AuthorId,
                AdvisorId = article.AdvisorId,
                CoAdvisorId = article.CoAdvisorId,
                DeliveryDates = deliveryDates
            };

            return articleDTO;
        }

        public void Delete(DataSession dataSession, long id)
        {
            if (!dataSession.IsAdmin)
                throw new Exception("Apenas Administradores podem usar esse metodo");

            var article = _repository.FindById(id);

            _unitOfWork.StartTransaction();

            if(article != null)
                _repository.Delete(article);

            _unitOfWork.Commit();
        }
    }
}
