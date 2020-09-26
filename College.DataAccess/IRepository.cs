using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace College.DataAccess
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        T GetSingle(Expression<Func<T, bool>> expression);
        void Add(T poco);
        void Update(T poco);
        void Delete(T poco);
    }
}
