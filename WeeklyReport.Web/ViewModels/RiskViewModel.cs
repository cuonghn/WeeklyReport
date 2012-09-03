using System.ComponentModel.DataAnnotations;

namespace WeeklyReport.Web.ViewModels
{
   public class RiskViewModel
   {
      public int Id { get; set; }
      [Required]
      public string Level { get; set; }
      [Required]
      public string Description { get; set; }
   }
}