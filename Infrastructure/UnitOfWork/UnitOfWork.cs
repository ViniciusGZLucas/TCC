using Domain.Interface;
using Infrastructure.Context;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private IctDbContext _context;

        public UnitOfWork(IctDbContext context)
        {
            _context = context;
        }

        public void StartTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }
    }
}
