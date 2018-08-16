using System;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Tr_Api.Models
{
    public class Response 
    {
        public HttpStatusCode StatusCode { get; set; }
        public object Body { get; set; } = null;

        public Response() { }
        public Response(HttpStatusCode statusCode, object body)
        {

            this.Body = body ?? "";
            this.StatusCode = statusCode;
        }
        public Response(object body)
        {
            this.StatusCode = HttpStatusCode.OK;
            this.Body = body;
        }
        public Response(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;
            this.Body = null;
        }
    }
}