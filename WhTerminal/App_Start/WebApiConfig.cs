﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WhTerminal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            


            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
