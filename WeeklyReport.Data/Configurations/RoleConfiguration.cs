using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class RoleConfiguration : EntityTypeConfiguration<Role>
   {
      public RoleConfiguration()
      {
         Property(r => r.RoleName).IsRequired().HasMaxLength(20);
         Property(r => r.Description).IsRequired().HasMaxLength(100);
      }
   }
}
