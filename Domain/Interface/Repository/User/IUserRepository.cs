using Domain.Entry;
using Domain.Interface.Repository.Base;

namespace Domain.Interface.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User? GetByEmail(string email);
        List<Role>? GetRolesByUser(long userId);
    }
}
