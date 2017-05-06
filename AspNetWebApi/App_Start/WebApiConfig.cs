using System.Web.Http;

namespace AspNetApiAngular
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            if (config.Formatters.XmlFormatter != null)
            {
                config.Formatters.Remove(config.Formatters.XmlFormatter);
            }
        }
    }
}
