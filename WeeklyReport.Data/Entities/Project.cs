
using System;
using System.Collections.Generic;

namespace WeeklyReport.Data.Entities
{
   public class Project
   {
      public int Id { get; set; }
      public string ProjectName { get; set; }
      public DateTime StartDate { get; set; }
      public User Leader { get; set; }
      public ICollection<User> Members { get; set; }
      public ICollection<Component> Components { get; set; }
      public bool IsActive { get; set; }
      public string Notes { get; set; }
   }
}
