using System;
using System.Web.Mvc;
using System.Web.WebPages;

namespace WeeklyReport.Web.Helpers
{
   public static class TemplateHelper
   {
      public static string Template(this HtmlHelper helper, Func<dynamic, HelperResult> tmpl)
      {
         var result = tmpl(null).ToString();
         return result;
      }
   }
}