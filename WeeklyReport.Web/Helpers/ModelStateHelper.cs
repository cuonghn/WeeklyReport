using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace WeeklyReport.Web.Helpers
{
   public static class ModelStateHelper
   {
      public static string GetErrors(this ModelStateDictionary modelState)
      {
         StringBuilder sb = new StringBuilder();
         foreach (var value in modelState.Values)
         {
            if (value.Errors.Any())
               sb.Append(value.Errors[0].ErrorMessage + "\n");
         }
         return sb.ToString();
      }
   }
}