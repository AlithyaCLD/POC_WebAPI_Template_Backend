using System;
using System.Web.Http.ExceptionHandling;
//using Tr_Api.Models;

namespace Tr_Api.Services
{    
    public class TrExceptionHandler : ExceptionHandler
    {
        ExceptionController controller;
        public TrExceptionHandler()
        {
            controller = new ExceptionController();
            //responseController = new Controllers.ResponseController();
        }
        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception;
            controller.GetResponse("exception handled", System.Net.HttpStatusCode.InternalServerError);
            /*var exceptionMessage = new ApiMessage(exception.Message);
            var response = new Response2(System.Net.HttpStatusCode.InternalServerError, exceptionMessage);*/

            //responseController.Send(response);
            //import a logger and log the exception ?
        }
        private class ExceptionController : Controllers.ResponseController
        {

        }
    }
}
