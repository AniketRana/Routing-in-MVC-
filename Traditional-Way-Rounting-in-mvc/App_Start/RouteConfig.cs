using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Traditional_Way_Rounting_in_mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //below are traditional way routing example

            //routes.MapRoute(
            //    name: "AllStudents",
            //    url: "students",
            //    defaults: new { Controller = "Student", action = "GetAllStudents" }
            //    );

            //routes.MapRoute(
            //    name: "AllStudentsA",
            //    url: "All",
            //    defaults: new { Controller = "Student", action = "GetAllStudents" }
            //    );

            //routes.MapRoute(
            //    name: "student",
            //    url: "students/{id}",
            //    defaults: new { Controller = "Student", action = "GetStudent"}
            //    );

            //routes.MapRoute(
            //    name: "studentAddress",
            //    url: "students/{id}/Address",
            //    defaults: new { Controller = "Student", action = "GetStudentAddress" },
            //    constraints:new { id =@"\d+"}
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
