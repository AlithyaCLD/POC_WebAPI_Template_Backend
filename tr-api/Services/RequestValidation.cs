using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Tr_Api.Models;

namespace Tr_Api.Services
{
    public class RequestValidation
    {
        private Controllers.ResponseController responseController;
        public RequestValidation()
        {
            responseController = new Controllers.ResponseController();
        }
        public bool Validate(HttpRequest request)
        {
            return false;
            Response response;
            try
            {
                var acceptLanguage = request.Headers.Get("Accept-Language");
                if (acceptLanguage != "en-CA")
                {
                    //response = new Response(HttpStatusCode.BadRequest, "accept Language is missing");
                    request.Headers.Remove("Accept-Language");
                    request.Headers.Add("Accept-Language", "en-CA");
                }                                
            }
            catch (Exception)
            {
                return false;
                
            }

            return true;
        }
    }
}