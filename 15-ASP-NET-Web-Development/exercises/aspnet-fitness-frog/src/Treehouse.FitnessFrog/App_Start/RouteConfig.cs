using System;
using System.Collections.Generic;
using Systen.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Treehouse.FitnessFrog
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapRoute(
        name: "Default",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Entries", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}
