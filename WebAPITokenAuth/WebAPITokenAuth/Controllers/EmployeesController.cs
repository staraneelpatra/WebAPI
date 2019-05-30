using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITokenAuth.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (TharEntities te = new TharEntities())
            {
                return te.Employees.ToList();
            }
        }
    }
}
