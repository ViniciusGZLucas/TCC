using Domain.Entry;
using Domain.Interface.Repository.Base;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Base
{
    public abstract class BaseRepository<TEntry> : IBaseRepository<TEntry> where TEntry : BaseEntry
    {
        private readonly DbSet<TEntry> _dbSet;
        private readonly IctDbContext _context;

        public BaseRepository(IctDbContext context)
        {
            _dbSet = context.Set<TEntry>();
            _context = context;
        }

        public TEntry? FindById(long id)
        {
            return _dbSet.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<TEntry> FindAll()
        {
            return _dbSet.ToList();
        }

        public long Create(TEntry entry)
        {
            _dbSet.Add(entry);

            return entry.Id;
        }

        public List<long> CreateRange(List<TEntry> listEntries)
        {
            _dbSet.AddRange(listEntries);
            _context.SaveChanges();

            return listEntries.Select(x => x.Id).ToList();
        }

        public void Update(TEntry entry)
        {
            _dbSet.Update(entry);
        }

        public void UpdateRange(List<TEntry> listEntries)
        {
            _dbSet.UpdateRange(listEntries);
        }

        public void Delete(TEntry entry)
        {
            _dbSet.Remove(entry);
        }

        public void DeleteRange(List<TEntry> listEntries)
        {
            _dbSet.RemoveRange(listEntries);
        }
    }
}
