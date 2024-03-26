namespace Domain.Interface.Repository.Base
{
    public interface IBaseRepository<TEntry>
    {
        long Create(TEntry entry);
        List<long> CreateRange(List<TEntry> listEntries);
        void Delete(TEntry entry);
        void DeleteRange(List<TEntry> listEntries);
        List<TEntry> FindAll();
        TEntry? FindById(long id);
        void Update(TEntry entry);
        void UpdateRange(List<TEntry> listEntries);
    }
}
