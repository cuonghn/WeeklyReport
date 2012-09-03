using System;
using System.Collections.Generic;

namespace WeeklyReport.Data.Entities
{
   public class Report
   {
      public int Id { get; set; }
      public int Week { get; set; }
      public DateTime From { get; set; }
      public DateTime To { get; set; }
      public User User { get; set; }
      public ICollection<WorkItem> WorkItems { get; set; }
   }
}
