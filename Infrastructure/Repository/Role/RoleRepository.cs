using Domain.Entry;
using Domain.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IctDbContext context) : base(context)
        {
        }
    }
}
