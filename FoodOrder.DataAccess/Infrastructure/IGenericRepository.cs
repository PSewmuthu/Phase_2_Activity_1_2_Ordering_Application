using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DataAccess.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate=null,string? includeproperties=null);
        T GetById(Expression<Func<T, bool>>? predicate = null, string? includeproperties = null);
        void Insert(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
    }
}
