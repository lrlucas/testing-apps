using System.Collections.Generic;
using API.Data;
using API.Entities;
using API.Interfaces;

namespace API.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;

        public ReviewRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Review entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Review> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Review GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Review entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Review entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateById(long id, Review entity)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }
    }
}