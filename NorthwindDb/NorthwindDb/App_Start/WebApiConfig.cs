﻿using NorthwindDb.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NorthwindDb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務
            config.EnableSystemDiagnosticsTracing();
            config.Filters.Add(new ApiErrorAttribute());
            config.Filters.Add(new ApiVersionAttribute());
            config.Filters.Add(new ApiRunTimeAttribute());
            

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "NotFound",
                routeTemplate: "{*path}",
                defaults: new { controller = "Error404", action = "NotFound" }
            );
        }
    }
}
