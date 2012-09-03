using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class RiskConfiguration : EntityTypeConfiguration<Risk>
   {
      public RiskConfiguration()
      {
         Property(r => r.Level).IsRequired().HasMaxLength(20);
         Property(r => r.Description).IsRequired().HasMaxLength(100);
      }
   }
}
