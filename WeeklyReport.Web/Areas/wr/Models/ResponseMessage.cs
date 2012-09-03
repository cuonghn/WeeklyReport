
namespace WeeklyReport.Web.Areas.wr.Models
{
   public class ResponseMessage
   {
      public bool Success { get { return string.IsNullOrEmpty(Message); } }
      public string Message { get; set; }
      public object Data { get; set; }
   }
}