using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
//using Tr_Api.Models;

namespace Tr_Api.Controllers
{
    public abstract class ResponseController : ApiController
    {
        protected string AcceptLanguage => Tr_Api.Services.Helpers.GetAcceptLanguage(this.Request.Headers.AcceptLanguage);
        public ResponseController()
        {
        }
        public IHttpActionResult GetResponse(object content, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            var responseMessage = new HttpResponseMessage(statusCode);
            responseMessage.RequestMessage = this.Request;            
            responseMessage.Content = Json(content).ExecuteAsync(new CancellationToken()).Result.Content;

            return new Response(responseMessage);            
        }
        private class Response : IHttpActionResult
        {
            HttpResponseMessage responseMessage;
            public Response(HttpResponseMessage responseMessage)
            {
                this.responseMessage = responseMessage;
            }

            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {
                return Task.FromResult(responseMessage);
            }
        }
    }
}
