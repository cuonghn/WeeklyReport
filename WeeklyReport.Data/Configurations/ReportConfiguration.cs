using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class ReportConfiguration : EntityTypeConfiguration<Report>
   {
      public ReportConfiguration()
      {
         Property(r => r.Week).IsRequired();
         HasRequired(r => r.User);
      }
   }
}
