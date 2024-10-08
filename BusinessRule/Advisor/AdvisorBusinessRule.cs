﻿using BusinessRule.Base;
using CrossCutting.DataSession;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;
using Domain.ViewModel.Article;

namespace BusinessRule
{
    public class AdvisorBusinessRule : BaseBusinessRule<IAdvisorRepository, AdvisorDTO, AdvisorViewModel, InputCreateAdvisorViewModel>, IAdvisorBusinessRule
    {
        public AdvisorBusinessRule(IAdvisorRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public AdvisorDTO Create(DataSession dataSession, InputCreateAdvisorViewModel viewModel)
        {
            var dto = base.Create(dataSession, viewModel);

            return dto;
        }

        public override void DTOValidationProcess(AdvisorDTO dto)
        {
        }

        public override void ViewModelValidationProcess(InputCreateAdvisorViewModel viewModel)
        {
        }

        public IList<AdvisorGridViewModel>? GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(DataSession dataSession, long id)
        {
            if (!dataSession.IsAdmin)
                throw new Exception("Apenas Administradores podem usar esse metodo");

            var advisor = _repository.FindById(id);

            _unitOfWork.StartTransaction();

            if (advisor != null)
                _repository.Delete(advisor);

            _unitOfWork.Commit();
        }
    }
}
