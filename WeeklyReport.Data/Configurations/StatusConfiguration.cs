using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class StatusConfiguration : EntityTypeConfiguration<Status>
   {
      public StatusConfiguration()
      {
         Property(r => r.State).IsRequired().HasMaxLength(30);
         Property(r => r.Description).IsRequired().HasMaxLength(100);
      }
   }
}
