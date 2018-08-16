using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Tr_Api.Models;

namespace Tr_Api.Controllers
{
    public class ResponseController : ApiController
    {
        
        public IHttpActionResult Send(Response response)
        {
            return Json(response);
        }
    }
}
