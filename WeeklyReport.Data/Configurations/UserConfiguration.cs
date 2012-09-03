using System.Data.Entity.ModelConfiguration;
using WeeklyReport.Data.Entities;

namespace WeeklyReport.Data.Configurations
{
   public class UserConfiguration : EntityTypeConfiguration<User>
   {
      public UserConfiguration()
      {
         Property(u => u.Alias).IsRequired().HasMaxLength(50);
         Property(u => u.UserName).IsRequired();
         Property(u => u.Password).IsRequired();
         HasRequired(u => u.Role);
      }
   }
}
