using WeeklyReport.Data.Abstracts;

namespace WeeklyReport.Data.Repositories
{
   public class UnitOfWork : IUnitOfWork
   {
      private readonly IReportContext context;

      public UnitOfWork(IReportContext context)
      {
         this.context = context;
      }

      public void Commit()
      {
         context.Save();
      }
   }
}
