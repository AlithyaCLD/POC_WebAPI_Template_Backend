using System;
using System.Net;
using System.Web.Http;
using DataService;
using Tr_Api.Models;
using Tr_Api.Services;

namespace Tr_Api.Controllers
{
    public class TemplateController : ApiController
    {
        private TemplateService dataService;
        public TemplateController()
        {
            dataService = new DataService.TemplateService();
        }
        [Route("api/template")]
        public IHttpActionResult Get()
        {            
            var UserList = dataService.Get();

            return new ResponseMessage(UserList, HttpStatusCode.OK, Request);
            //return base.GetResponse(UserList);
        }
        [Route("api/template/{id}")]
        public IHttpActionResult Get(int id)
        {
            var model = dataService.Get(id);

            return new ResponseMessage(model, HttpStatusCode.Created, Request);
        }
        [Route("api/menu")]
        public IHttpActionResult GetAvailablePeriods()
        {
            var periods = dataService.GetAvailablePeriods();

            return new ResponseMessage(periods, HttpStatusCode.OK, Request);            
        }
        [Route("api/accept")]
        public IHttpActionResult GetAcceptLanguage()
        {
            var acceptLanguage = Helpers.GetAcceptLanguage(Request.Headers.AcceptLanguage);

            return new ResponseMessage(acceptLanguage, HttpStatusCode.OK, Request);            
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