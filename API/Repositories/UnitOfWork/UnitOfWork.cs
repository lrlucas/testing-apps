using API.Data;
using API.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace API.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        private IDbContextTransaction _transaction;
        private ReviewRepository _reviewRepository;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public IReviewRepository ReviewRepository
        {
            get { return _reviewRepository ??= new ReviewRepository(_dataContext); }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }

        public void BeginTransaction()
        {
            _transaction = _dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                Save();
                _transaction.Commit();
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
    }
}