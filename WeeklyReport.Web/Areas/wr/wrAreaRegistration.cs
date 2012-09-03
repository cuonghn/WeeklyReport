using System.Web.Mvc;

namespace WeeklyReport.Web.Areas.wr
{
   public class wrAreaRegistration : AreaRegistration
   {
      public override string AreaName
      {
         get
         {
            return "wr";
         }
      }

      public override void RegisterArea(AreaRegistrationContext context)
      {
         context.MapRoute(
             "wr_default",
             "wr/{controller}/{action}/{id}",
             new { action = "Index", id = UrlParameter.Optional }
         );
      }
   }
}
