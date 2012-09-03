using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Repositories
{
   public class ProjectRepository : BaseRepository<Project>, IProjectRepository
   {
      public ProjectRepository(IReportContext context, IUnitOfWork unitOfWork)
         : base(unitOfWork, context)
      { }
   }
}
