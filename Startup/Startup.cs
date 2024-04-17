using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace RecipeFinderPrototype.Startup
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var mediaType = new MediaTypeHeaderValue("application/json");

            var formatter = new JsonMediaTypeFormatter();
            formatter.SupportedMediaTypes.Clear();
            formatter.SupportedMediaTypes.Add(mediaType);

            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.Clear();
            config.Formatters.Add(formatter);

            appBuilder.UseCors(CorsOptions.AllowAll);

            //config.Filters.Add(new AuthorizeAttribute());
            appBuilder.UseWebApi(config);
        }
    }
}
