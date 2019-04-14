
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAdapter;
using System.Data;

namespace WebAPISQL.Controllers
{
    public class DefaultController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (TharEntitiesConnection con = new TharEntitiesConnection())
            {
                return con.Employees.ToList();
            }
        }
        public Employee Get(int id)
        {
            using (TharEntitiesConnection con = new TharEntitiesConnection())
            {

                return con.Employees.Where(x => x.Id == id).FirstOrDefault();
                //return con.Employees.FirstOrDefault(x => x.Id == id);
            }
        }
        public bool Put([FromUri]Employee value, int id )
        {
            using (TharEntitiesConnection con = new TharEntitiesConnection())
            {

                Employee emp = new Employee();
                con.Employees.Where(x => x.Id == id);
                {
                    emp.Name = value.ToString();
                }
                return true;
                
            }
        }
    }
}
