using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class ProjectConfiguration : EntityTypeConfiguration<Project>
   {
      public ProjectConfiguration()
      {
         Property(p => p.ProjectName)
            .IsRequired()
            .HasMaxLength(50);

         HasRequired(p => p.Leader);
      }
   }
}
