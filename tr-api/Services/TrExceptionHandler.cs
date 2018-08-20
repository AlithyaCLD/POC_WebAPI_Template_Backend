using System;
using System.Web.Http.ExceptionHandling;
using Tr_Api.Models;

namespace Tr_Api.Services
{    
    public class TrExceptionHandler : ExceptionHandler
    {
        public TrExceptionHandler()
        {
        }
        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception;

            var exceptionMessage = new ExceptionMessage();
            exceptionMessage.Message = exception.Message;
            exceptionMessage.StackTrace = exception.StackTrace;

            context.Result = new ResponseMessage(exceptionMessage, System.Net.HttpStatusCode.InternalServerError, context.Request);
            //import a logger and log the exception ?
        }
        private class ExceptionMessage
        {
            public string Message { get; set; }
            public string StackTrace { get; set; }
        }
    }
}
