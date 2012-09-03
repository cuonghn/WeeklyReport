using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Repositories
{
   public class UserRepository : BaseRepository<User>, IUserRepository
   {
      public UserRepository(IReportContext context, IUnitOfWork unitOfWork)
         : base(unitOfWork, context)
      { }
   }
}
