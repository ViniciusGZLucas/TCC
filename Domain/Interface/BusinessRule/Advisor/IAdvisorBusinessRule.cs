using CrossCutting.DataSession;
using Domain.DTO;
using Domain.ViewModel;

namespace Domain.Interface.BusinessRule
{
    public interface IAdvisorBusinessRule
    {
        AdvisorDTO Create(DataSession dataSession, InputCreateAdvisorViewModel viewModel);
    }
}
