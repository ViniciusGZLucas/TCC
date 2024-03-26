namespace Domain.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
        void StartTransaction();
    }
}
