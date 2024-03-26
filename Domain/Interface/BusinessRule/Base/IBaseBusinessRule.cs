namespace Domain.Interface.BusinessRule.Base
{
    public interface IBaseBusinessRule<TRepository, TDTO, TViewModel>
    {
        TDTO Create(TViewModel viewModel);
    }
}
