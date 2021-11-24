namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IReviewRepository ReviewRepository { get; }
        void Save();
        void Commit();
        void Rollback();
        void BeginTransaction();
    }
}