﻿using GrupoADyD.Web.Mvc.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace GrupoADyD.Web.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            UnityWebActivator.Start();
        }
    }
}