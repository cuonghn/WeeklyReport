using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Repositories
{
   public class ComponentRepository : BaseRepository<Component>, IComponentRepository
   {
      public ComponentRepository(IReportContext context, IUnitOfWork unitOfWork)
         : base(unitOfWork, context)
      { }
   }
}
