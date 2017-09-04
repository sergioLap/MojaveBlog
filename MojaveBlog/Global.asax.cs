using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MojaveBlog.Core;
using MvcBundleConfig.Models;
using Ninject;
using Ninject.Web.Common;

namespace MojaveBlog
{
    public class MvcApplication : NinjectHttpApplication
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();


        protected void Application_Start()
        {
            logger.Info("Application Start");

            AreaRegistration.RegisterAllAreas();

        }

        protected override void OnApplicationStarted()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            base.OnApplicationStarted();
        }
        public void Init()
        {
            logger.Info("Application Init");
        }

        public void Dispose()
        {
            logger.Info("Application Dispose");
        }

        protected void Application_Error()
        {
            logger.Info("Application Error");
        }


        protected void Application_End()
        {
            logger.Info("Application End");
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(new MojaveRepositoryModule());
            kernel.Bind<IRepository>().To<MojaveRepository>();
            return kernel;
        }
    }
}
