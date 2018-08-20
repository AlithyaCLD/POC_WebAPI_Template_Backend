using System;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Tr_Api.Models
{
    public class ResponseMessage : IHttpActionResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public object Body { get; set; }
        private HttpRequestMessage requestMessage;
        public ResponseMessage(object body, HttpStatusCode statusCode, HttpRequestMessage request)
        {
            if (request == null)
            {
                throw new ArgumentException("request cannot be null");
            }
            this.StatusCode = statusCode;
            this.Body = body;
            this.requestMessage = request;
        }
        public ResponseMessage(object body, HttpRequestMessage request)
        {
            if (request == null)
            {
                throw new ArgumentException("request cannot be null");
            }
            this.Body = body;
            this.StatusCode = HttpStatusCode.OK;
            this.requestMessage = request;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var responseMessage = new HttpResponseMessage(this.StatusCode);
            responseMessage.Content = new ObjectContent(Body.GetType(), this.Body, new System.Net.Http.Formatting.JsonMediaTypeFormatter());
            responseMessage.RequestMessage = this.requestMessage;

            return Task.FromResult(responseMessage);
        }
    }
}