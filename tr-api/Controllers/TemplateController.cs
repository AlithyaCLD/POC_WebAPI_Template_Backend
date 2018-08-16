using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataService;
using DataService.Models;
using Tr_Api.Models;

namespace Tr_Api.Controllers
{
    public class TemplateController : ApiController
    {
        private DataService.DataService dataService;
        public TemplateController()
        {
            dataService = new DataService.DataService();
        }
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var acceptLanguage = Request.Headers.AcceptLanguage;
            var UserList = dataService.Get();

            //return Json(new Response(UserList));
            return Json(new { StatusCode = HttpStatusCode.OK,  UserList = dataService.Get() } );
            //return Json(new Response(dataService.Get()));
        }
        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var model = dataService.Get(id);
            return Json(new Response(model));




            /*try
            {                
                var model = dataService.Get(id);
                return Json(new Response(model));
                //return Json(new Response(HttpStatusCode.OK, model));                
            }
            catch (System.Exception ex)
            {
                var exception = new Models.ApiMessage();
                exception.Message = ex.Message + " any custom/user friendly message?";
                return Json(new Response(HttpStatusCode.NotFound, exception));
                //return Json(new Response(new Models.Exception("cannot get a user")));
                //return Json(new Response(HttpStatusCode.BadRequest, new Models.Exception("cannot get a user")));                
            } */           
        }
        [Route("api/menu")]
        public IHttpActionResult GetAvailablePeriods()
        {
            var periods = dataService.GetAvailablePeriods();

            return Json(new Response(periods));            
        }
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}