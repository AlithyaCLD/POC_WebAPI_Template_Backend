using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tr_Api.Models
{
    public class ApiMessage
    {
        public string Content { get; set; }
        public ApiMessage()
        {
            this.Content = "";
        }
        public ApiMessage(string content)
        {
            this.Content = content ?? "";
        }
    }
}