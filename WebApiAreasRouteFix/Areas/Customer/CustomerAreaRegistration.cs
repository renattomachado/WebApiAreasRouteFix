using System.Web.Http;
using System.Web.Mvc;
using WebApiAreasRouteFix.Extensions;

namespace WebApiAreasRouteFix.Areas.Customer
{
    public class CustomerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Customer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapHttpRoute(
               "Customer_DefaultApi",
               "Customer/api/{controller}/{id}",
               new { id = RouteParameter.Optional }
          );

            context.MapRoute(
                "Customer_default",
                "Customer/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}