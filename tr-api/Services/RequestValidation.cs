using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
//using Tr_Api.Models;

namespace Tr_Api.Services
{
    public class RequestValidation
    {
        public RequestValidation()
        {
        }
        public bool Validate(HttpRequest request)
        {            
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