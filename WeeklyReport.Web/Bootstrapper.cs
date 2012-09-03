using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using WeeklyReport.Data.Abstracts;
using WeeklyReport.Data.Context;
using WeeklyReport.Data.Repositories;

namespace WeeklyReport.Web
{
   public static class Bootstrapper
   {
      public static void Initialise()
      {
         var container = BuildUnityContainer();

         DependencyResolver.SetResolver(new UnityDependencyResolver(container));
      }

      private static IUnityContainer BuildUnityContainer()
      {
         var container = new UnityContainer();
         container.RegisterType<IReportContext, ReportContext>(new HierarchicalLifetimeManager())
                  .RegisterType<IUnitOfWork, UnitOfWork>()
                  .RegisterType<IProjectRepository, ProjectRepository>()
                  .RegisterType<IUserRepository, UserRepository>()
                  .RegisterType<IRiskRepository, RiskRepository>();
         return container;
      }
   }
}