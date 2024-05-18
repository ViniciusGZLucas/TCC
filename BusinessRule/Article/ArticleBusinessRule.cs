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

        public ArticleBusinessRule(IArticleRepository repository, IUnitOfWork unitOfWork, IArticleDocumentRepository articleDocumentRepository, IUserRepository userRepository) : base(repository, unitOfWork)
        {
            _articleDocumentRepository = articleDocumentRepository;
            _userRepository = userRepository;
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
    }
}
