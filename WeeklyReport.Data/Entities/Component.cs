
namespace WeeklyReport.Data.Entities
{
   public class Component
   {
      public int Id { get; set; }
      public string ComponentName { get; set; }
      public Project Project { get; set; }
   }
}
