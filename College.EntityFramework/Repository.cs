using College.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace College.EntityFramework
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CollegeDbContext _context;

        public Repository(CollegeDbContext context)
        {
            _context = context;
        }
        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().FirstOrDefault(expression);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
             _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
