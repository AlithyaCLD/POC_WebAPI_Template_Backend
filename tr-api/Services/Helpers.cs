using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http.Headers;
using Tr_Api.Models;

namespace Tr_Api.Services
{
    public class Helpers
    {
        public static string GetAcceptLanguage(HttpHeaderValueCollection<StringWithQualityHeaderValue> headers)
        {
            return headers.ElementAt(0).Value;
        }
        public static ApiMessage HandleException(Exception exception)
        {
            // logging ?

            ApiMessage message = new ApiMessage(exception.Message);

            return message;
        }
    }
}