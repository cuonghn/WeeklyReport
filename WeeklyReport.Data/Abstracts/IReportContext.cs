using System.Data.Entity;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Abstracts
{
   public interface IReportContext
   {
      DbSet<User> Users { get; set; }
      DbSet<Project> Projects { get; set; }
      DbSet<Role> Roles { get; set; }
      DbSet<Report> Reports { get; set; }
      DbSet<Component> Components { get; set; }
      DbSet<UserProfile> UserProfiles { get; set; }
      DbSet<WorkItem> WorkItems { get; set; }
      DbSet<Risk> Risks { get; set; }
      DbSet<Status> Statuses { get; set; }
      void Save();
      DbContext Current { get; }
   }
}
