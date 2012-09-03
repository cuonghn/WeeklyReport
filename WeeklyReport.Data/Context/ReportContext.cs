using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Configurations;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Context
{
   public class ReportContext : DbContext, IReportContext
   {
      #region IReportContext members

      public DbSet<User> Users { get; set; }
      public DbSet<Project> Projects { get; set; }
      public DbSet<Role> Roles { get; set; }
      public DbSet<Report> Reports { get; set; }
      public DbSet<Component> Components { get; set; }
      public DbSet<UserProfile> UserProfiles { get; set; }
      public DbSet<WorkItem> WorkItems { get; set; }
      public DbSet<Risk> Risks { get; set; }
      public DbSet<Status> Statuses { get; set; }

      public DbContext Current
      {
         get { return this; }
      }

      public void Save()
      {
         SaveChanges();
      }

      #endregion

      #region DbContext overridden members

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         ConfigureEntity(modelBuilder);
         base.OnModelCreating(modelBuilder);
      }

      protected override void Dispose(bool disposing)
      {
         base.Dispose(disposing);
         Debug.WriteLine("-- Context is disposed --");
      }

      #endregion

      #region Private members

      private void ConfigureEntity(DbModelBuilder modelBuilder)
      {
         modelBuilder.Configurations.Add(new ProjectConfiguration());
         modelBuilder.Configurations.Add(new UserConfiguration());
         modelBuilder.Configurations.Add(new RoleConfiguration());
         modelBuilder.Configurations.Add(new ReportConfiguration());
         modelBuilder.Configurations.Add(new WorkItemConfiguration());
         modelBuilder.Configurations.Add(new RiskConfiguration());
         modelBuilder.Configurations.Add(new ComponentConfiguration());
         modelBuilder.Configurations.Add(new StatusConfiguration());
         modelBuilder.Configurations.Add(new UserProfileConfiguration());
      }

      #endregion
   }
}
