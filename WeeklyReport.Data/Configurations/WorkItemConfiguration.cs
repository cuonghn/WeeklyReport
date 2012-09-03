using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class WorkItemConfiguration : EntityTypeConfiguration<WorkItem>
   {
      public WorkItemConfiguration()
      {
         Property(w => w.Content).IsRequired().HasMaxLength(int.MaxValue);
         Property(w => w.HourCost).IsRequired();
         Property(w => w.HourNonCost).IsRequired();
         Property(w => w.Severity).IsRequired();
         HasRequired(w => w.Risk);
         HasRequired(w => w.Status);
      }
   }
}
