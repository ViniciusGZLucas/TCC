using Domain.Entry;
using Domain.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class AdvisorRepository : BaseRepository<Advisor>, IAdvisorRepository
    {
        public AdvisorRepository(IctDbContext context) : base(context)
        {
        }
    }
}
