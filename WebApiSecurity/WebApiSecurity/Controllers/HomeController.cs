using EmployeeFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;

namespace WebApiSecurity.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [BasicAuthentication]
        public HttpResponseMessage GetEmployee(String desig)
        {
            string designation = Thread.CurrentPrincipal.Identity.Name;
        
            using (TharEntities con = new TharEntities())
            {
                switch (designation.ToLower())
                {
                    case "accountant":
                        return Request.CreateResponse(HttpStatusCode.OK, con.Employees.Where(x=>x.Designation=="accountant").ToList());
                    default:
                        return (Request.CreateResponse(HttpStatusCode.BadRequest));
                }
                
            }
        } 
    }
}
