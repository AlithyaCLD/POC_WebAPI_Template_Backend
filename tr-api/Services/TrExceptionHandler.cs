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
            context.Result = new ResponseMessage("any error message...", System.Net.HttpStatusCode.InternalServerError, context.Request);
            //import a logger and log the exception ?
        }        
    }
}
