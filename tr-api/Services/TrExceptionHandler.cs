using System;
using System.Web.Http.ExceptionHandling;
using Tr_Api.Models;

namespace Tr_Api.Services
{    
    public class TrExceptionHandler : ExceptionHandler
    {
        Controllers.ResponseController responseController;
        public TrExceptionHandler()
        {
            responseController = new Controllers.ResponseController();
        }
        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception;

            var exceptionMessage = new ApiMessage(exception.Message);
            var response = new Response(System.Net.HttpStatusCode.InternalServerError, exceptionMessage);

            responseController.Send(response);
            //import a logger and log the exception ?
        }        
    }
}
