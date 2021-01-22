﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DMS_DTCK
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "DMS_DTCK.Controllers" }

            );
            //routes.MapRoute(
            //    name: "Room",
            //    url: "{Student}/{Room}/{RoomCategory}",
            //    defaults: new { controller = "Room", action = "RoomCategory", id = UrlParameter.Optional },
            //    namespaces: new[] { "DMS_DTCK.Controllers" }

            //);
            //routes.MapRoute(
            //    name: "Registration",
            //    url: "{Area}/{controller}/{action}/{id}",
            //    defaults: new { Area= "Student",controller = "Room", action = "Registration", id = "" },
            //    namespaces: new[] { "DMS_DTCK.Controllers" }

            //);
        }
    }
}
