using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataService;
using DataService.Models;
using Tr_Api.Models;
using Tr_Api.Services;

namespace Tr_Api.Controllers
{
    public class TemplateController : ResponseController
    {
        private DataService.DataService dataService;
        public TemplateController()
        {
            dataService = new DataService.DataService();
        }
        [Route("api/template")]
        public IHttpActionResult Get()
        {            
            var UserList = dataService.Get();

            return base.GetResponse(UserList);            
        }
        [Route("api/template/{id}")]
        public IHttpActionResult Get(int id)
        {
            var model = dataService.Get(id);

            try
            {
                //return Json(new Response(HttpStatusCode.BadRequest, model));
                return base.GetResponse(model);
                //return Json(new { Code = 200, ErrorMessage = "Could not retrieve template." });
            }
            catch (Exception ex)
            {
                 return base.GetResponse(Helpers.HandleException(ex), HttpStatusCode.InternalServerError);

                //return Json(new { Code = 500, ErrorMessage = "Could not retrieve template." });

            }
        }
        [Route("api/menu")]
        public IHttpActionResult GetAvailablePeriods()
        {
            var periods = dataService.GetAvailablePeriods();

            return base.GetResponse(periods);            
        }
        [Route("api/accept")]
        public IHttpActionResult GetAcceptLanguage()
        {
            //var acceptLanguage = Helpers.GetAcceptLanguage(Request.Headers.AcceptLanguage);

            return base.GetResponse(new ApiMessage(base.AcceptLanguage), HttpStatusCode.BadRequest);
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