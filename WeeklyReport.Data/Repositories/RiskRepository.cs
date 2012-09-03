using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Repositories
{
   public class RiskRepository : BaseRepository<Risk>, IRiskRepository
   {
      public RiskRepository(IReportContext context, IUnitOfWork unitOfWork)
         : base(unitOfWork, context)
      { }
   }
}
