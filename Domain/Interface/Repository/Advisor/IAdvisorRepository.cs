using Domain.Entry;
using Domain.Interface.Repository.Base;
using Domain.ViewModel;

namespace Domain.Interface.Repository
{
    public interface IAdvisorRepository : IBaseRepository<Advisor>
    {
        IList<AdvisorGridViewModel> GetAll();
    }
}
