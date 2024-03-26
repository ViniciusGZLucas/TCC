using Domain.Entry;
using Domain.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IctDbContext context) : base(context)
        {
        }
    }
}
