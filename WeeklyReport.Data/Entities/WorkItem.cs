using System;

namespace WeeklyReport.Data.Entities
{
   public class WorkItem
   {
      public int Id { get; set; }
      public DateTime Date { get; set; }
      public string Content { get; set; }
      public int HourCost { get; set; }
      public int HourNonCost { get; set; }
      public int Severity { get; set; }
      public Risk Risk { get; set; }
      public Status Status { get; set; }
      public string Notes { get; set; }
      public Report Report { get; set; }
   }
}
