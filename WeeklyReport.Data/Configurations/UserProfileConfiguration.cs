using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class UserProfileConfiguration : EntityTypeConfiguration<UserProfile>
   {
      public UserProfileConfiguration()
      {
         Property(u => u.ImagePath).IsRequired().HasMaxLength(255);
      }
   }
}
