using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using WeeklyReport.Data.Abstracts;

namespace WeeklyReport.Data.Repositories
{
   public class BaseRepository<T> : IBaseRepository<T> where T : class
   {
      private readonly IUnitOfWork unitOfWork;
      private DbContext context;
      private IDbSet<T> dbSet;

      public BaseRepository(IUnitOfWork unitOfWork, IReportContext context)
      {
         this.unitOfWork = unitOfWork;
         this.context = context.Current;
         this.dbSet = this.context.Set<T>();
      }

      public T Get(object key)
      {
         return dbSet.Find(key);
      }

      public IEnumerable<T> GetAll()
      {
         return dbSet.ToList();
      }

      public IEnumerable<T> GetAll(Expression<Func<T, bool>> exp)
      {
         return dbSet.Where(exp);
      }

      public void Add(T entity)
      {
         context.Entry<T>(entity).State = EntityState.Added;
         Commit();
      }

      public void Update(T entity)
      {
         context.Entry<T>(entity).State = EntityState.Modified;
         Commit();
      }

      public void Delete(T entity)
      {
         context.Entry<T>(entity).State = EntityState.Deleted;
         Commit();
      }

      private void Commit()
      {
         unitOfWork.Commit();
      }
   }
}
