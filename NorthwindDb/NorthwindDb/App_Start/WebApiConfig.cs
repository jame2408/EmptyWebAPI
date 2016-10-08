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

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
