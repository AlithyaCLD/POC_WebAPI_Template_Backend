using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tr_Api.Models
{
    public class ApiMessage
    {
        public string Message { get; set; }
        public ApiMessage()
        {
            this.Message = "";
        }
        public ApiMessage(string message)
        {
            this.Message = message ?? "";
        }
    }
}