
using System;
using System.Collections.Generic;
namespace WeeklyReport.Data.Entities
{
   public class User
   {
      public Guid Id { get; set; }
      public string Alias { get; set; }
      public string UserName { get; set; }
      public string Password { get; set; }
      public UserProfile Profile { get; set; }
      public ICollection<Report> Reports { get; set; }
      public Role Role { get; set; }
      public ICollection<Project> Projects { get; set; }
   }
}
