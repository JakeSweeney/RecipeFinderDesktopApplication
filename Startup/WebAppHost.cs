using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFinderPrototype.Startup
{
    internal class WebAppHost
    {
        private IDisposable _server = null;
        public String baseAddress { get; set; } = String.Empty;

        public void Start(String baseAddress)
        {
            AppDomain.CurrentDomain.Load(typeof(Microsoft.Owin.Host.HttpListener.OwinHttpListener).Assembly.GetName());

            this.baseAddress = baseAddress;
            _server = WebApp.Start<Startup>(url: baseAddress);
        }

        public void Stop()
        {
            if (_server != null)
            {
                _server.Dispose();
                _server = null;
            }
        }
    }
}
