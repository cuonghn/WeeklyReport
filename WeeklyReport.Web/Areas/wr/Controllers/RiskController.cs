using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Entities;
using WeeklyReport.Web.Areas.wr.Models;
using WeeklyReport.Web.Helpers;
using WeeklyReport.Web.ViewModels;

namespace WeeklyReport.Web.Areas.wr.Controllers
{
   public class RiskController : Controller
   {
      private readonly IRiskRepository riskRepository;

      public RiskController(IRiskRepository riskRepository)
      {
         this.riskRepository = riskRepository;
         Mapper.CreateMap<Risk, RiskViewModel>();
         Mapper.CreateMap<RiskViewModel, Risk>();
      }

      public ActionResult Index()
      {
         return View();
      }

      [HttpPost]
      public JsonResult Create(RiskViewModel riskModel)
      {
         var rm = new ResponseMessage();

         if (ModelState.IsValid)
         {
            try
            {
               var risk = Mapper.Map<Risk>(riskModel);
               riskRepository.Add(risk);
               rm.Data = risk;
            }
            catch
            {
               rm.Message = "Error occurred, please try again.";
            }
         }
         else
            rm.Message = ModelState.GetErrors();

         return Json(rm);
      }

      [HttpPost]
      public JsonResult GetAll()
      {
         var rm = new ResponseMessage();
         try
         {
            var risks = riskRepository.GetAll();
            var data = from r in risks
                       select Mapper.Map<RiskViewModel>(r);

            rm.Data = data;
         }
         catch
         {
            rm.Message = "Error occurred, please try again.";
         }
         return Json(rm);
      }

      [HttpPost]
      public JsonResult Save(RiskViewModel riskModel)
      {
         var rm = new ResponseMessage();
         try
         {
            if (!ModelState.IsValid)
            {
               rm.Message = ModelState.GetErrors();
               return Json(rm);
            }
            var risk = Mapper.Map<Risk>(riskModel);
            riskRepository.Update(risk);
         }
         catch
         {
            rm.Message = "Error occurred, please try again.";
         }
         return Json(rm);
      }

      [HttpPost]
      public JsonResult Delete(RiskViewModel riskModel)
      {
         var rm = new ResponseMessage();
         try
         {
            var risk = Mapper.Map<Risk>(riskModel);
            riskRepository.Delete(risk);
            rm.Data = risk;
         }
         catch
         {
            rm.Message = "Error occurred, please try again.";
         }
         return Json(rm);
      }

   }
}
