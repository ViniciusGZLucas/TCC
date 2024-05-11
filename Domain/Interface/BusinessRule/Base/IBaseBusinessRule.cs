using CrossCutting.DataSession;

namespace Domain.Interface.BusinessRule.Base
{
    public interface IBaseBusinessRule<TRepository, TDTO, TViewModel, TInputCreateViewModel>
    {
        TDTO Create(DataSession dataSession, TInputCreateViewModel viewModel);
    }
}
