using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pruebaPacifica
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
           routes.MapRoute(
               name: "getProvince",
               url: "{controller}/{action}/getProvince",
               defaults: new { controller = "Home", action = "provinciasFiltro", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Registrar",
                url: "{controller}/{action}/Registrar",
                defaults: new { controller = "Registro", action = "Registrar", id = UrlParameter.Optional }
            );

        }
    }
}
