using EmployeeDataAdapter;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public HttpResponseMessage Post([FromBody]Employee emp)
        {
            using (TharEntitiesConnection con = new TharEntitiesConnection())
            {
                con.Employees.Add(emp);
                con.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, emp.Name);

            }
        }
        public HttpResponseMessage Put(int id, [FromBody]Employee value)
        {
            using (TharEntitiesConnection con = new TharEntitiesConnection())
            {

                //Employee emp = new Employee();
                var ent = con.Employees.FirstOrDefault(x => x.Id == id);
                {
                    ent.Name = value.Name;
                    con.SaveChanges();
                }
                return Request.CreateResponse(HttpStatusCode.OK, value.Id);

            }
        }
        public HttpResponseMessage Delete(int id)
        {
            using (TharEntitiesConnection con = new TharEntitiesConnection())
            {
                Employee entity = con.Employees.FirstOrDefault(x => x.Id == id);
                con.Employees.Remove(entity);
                con.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.OK, id);
        }
    }
}
