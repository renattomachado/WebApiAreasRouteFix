using System.Web.Http;
using System.Web.Mvc;
using WebApiAreasRouteFix.Extensions;

namespace WebApiAreasRouteFix.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapHttpRoute(
               "Admin_DefaultApi",
               "Admin/api/{controller}/{id}",
               new { id = RouteParameter.Optional }
          );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}