using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Tr_Api.Services;

namespace Tr_Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        RequestValidation requestValidation;
        public WebApiApplication()
        {
            requestValidation = new RequestValidation();
        }
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (!requestValidation.Validate(HttpContext.Current.Request))
            {
                Application_EndRequest(sender, e);
            }
        }
        protected void Application_EndRequest(object sender, EventArgs e)
        {

        }
    }
}
