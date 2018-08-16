using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using Tr_Api.Models;



namespace Tr_Api.Services
{
    public class HttpValidationModule : IHttpModule
    {
        private Controllers.ResponseController responseController;
        private RequestValidation requestValidation;
        HttpApplication app;
        public HttpValidationModule()
        {
            requestValidation = new RequestValidation();
            responseController = new Controllers.ResponseController();
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            this.app = context;
            context.BeginRequest += (new EventHandler(this.Application_BeginRequest));
            context.EndRequest += (new EventHandler(this.Application_EndRequest));
        }
        private void Application_BeginRequest(object source, EventArgs e)
        {
            if (!requestValidation.Validate(app.Request))
            {
                //var response = new Response(HttpStatusCode.NotFound, "accept language is missing");
                //System.Net.Http.HttpResponseMessage msg = new System.Net.Http.HttpResponseMessage();
                //msg.Content = new System.Net.Http.StringContent("Error!");
                //app.Response.Write(msg.Content);
                // how to call an ApiController to get a response? We need to append a response to app.Request                
                //app.CompleteRequest();
            }
        }
        private void Application_EndRequest(object source, EventArgs e)
        {
            
        }
    }
}