using System.Web.Mvc;
using WeeklyReport.Data.Abstracts;

namespace WeeklyReport.Web.Controllers
{
   public class HomeController : Controller
   {
      private readonly IProjectRepository projectRepository;

      public HomeController(IProjectRepository projectRepository)
      {
         this.projectRepository = projectRepository;
      }

      public ActionResult Index()
      {
         var p = projectRepository.GetAll();
         return View();
      }

   }
}
