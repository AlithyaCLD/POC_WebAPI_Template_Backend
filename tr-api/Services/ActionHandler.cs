using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Tr_Api.Controllers;

namespace Tr_Api.Services
{
    public class ActionHandler : System.Net.Http.DelegatingHandler
    {
        private ResponseController responseController;
        public ActionHandler()
        {
            responseController = new ResponseController();
        }
        protected async override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var _response = new Models.Response(System.Net.HttpStatusCode.BadRequest, "error!");
            responseController.Send(_response);
            //Debug.WriteLine("Process request");
            // Call the inner handler.
            //var response = await base.SendAsync(request, cancellationToken);
            var response = await responseController.Send(_response).ExecuteAsync(cancellationToken);
            //Debug.WriteLine("Process response");
            return response;
        }
    }
}