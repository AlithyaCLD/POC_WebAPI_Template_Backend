using System;
using System.Net;
using System.Web.Http;
using Tr_Api.Models;
using Tr_Api.Services;
using Services.Employee;

namespace Tr_Api.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeFacade employeeService;
        public EmployeeController()
        {
            employeeService = new EmployeeFacade();
        }
        [Route("api/employee")]
        public IHttpActionResult Get()
        {            
            var employees = employeeService.Get();

            return new ResponseMessage(employees, HttpStatusCode.OK, Request);
            //return base.GetResponse(UserList);
        }
        [Route("api/employee/{id}")]
        public IHttpActionResult Get(int id)
        {
            var employee = employeeService.Get(id);

            return new ResponseMessage(employee, HttpStatusCode.Created, Request);
        }
        [Route("api/menu")]
        public IHttpActionResult GetAvailablePeriods()
        {
            var periods = employeeService.GetAvailablePeriods();

            return new ResponseMessage(periods, Request);            
        }
        [Route("api/accept")]
        public IHttpActionResult GetAcceptLanguage()
        {
            var acceptLanguage = Helpers.GetAcceptLanguage(Request.Headers.AcceptLanguage);

            return new ResponseMessage(acceptLanguage, Request);            
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