using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Repositories
{
   public class WorkItemRepository : BaseRepository<WorkItem>, IWorkItemRepository
   {
      public WorkItemRepository(IReportContext context, IUnitOfWork unitOfWork)
         : base(unitOfWork, context)
      { }
   }
}
