using Domain.Entry;
using Domain.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IctDbContext context) : base(context)
        {
        }

        public User? GetByEmail(string email)
        {
            var user = (from i in _dbSet
                        where i.Email == email
                        select i).FirstOrDefault();

            return user;
        }

        public List<Role>? GetRolesByUser(long userId)
        {
            var roles = (from user in _dbSet
                         join userrole in _context.UserRoles on user.Id equals userrole.UserId
                         join role in _context.Roles on userrole.RoleId equals role.Id
                         where user.Id == userId
                         select role).ToList();

            return roles;
        }
    }
}
