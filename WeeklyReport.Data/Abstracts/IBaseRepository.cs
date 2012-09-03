using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WeeklyReport.Data.Abstracts
{
   public interface IBaseRepository<T> where T : class
   {
      T Get(object key);
      IEnumerable<T> GetAll();
      IEnumerable<T> GetAll(Expression<Func<T, bool>> exp);
      void Add(T entity);
      void Update(T entity);
      void Delete(T entity);
   }
}
