using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class ComponentConfiguration : EntityTypeConfiguration<Component>
   {
      public ComponentConfiguration()
      {
         Property(c => c.ComponentName).IsRequired().HasMaxLength(70);
         HasRequired(c => c.Project);
      }
   }
}
