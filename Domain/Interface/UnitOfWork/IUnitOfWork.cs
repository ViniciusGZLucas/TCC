namespace Domain.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
        void SaveChanges();
        void StartTransaction();
    }
}
