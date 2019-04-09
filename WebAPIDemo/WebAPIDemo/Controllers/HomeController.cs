using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class HomeController:ApiController
    {
        public static List<string> values = new List<string>() { "Anil", "Musi", "Dhani" };

        public IEnumerable<string> Get()
        {
            return values;
        }

        public string Get(int id)
        {
            return values[id];
        }
       public void Post([FromBody]string newvalue)
        {
            values.Add(newvalue);
        }
        public void Put(int id, [FromBody]string newvalue)
        {
            values[id] = newvalue;
        }
        public void Delete(int id)
        {
            values.RemoveAt(id);
        }
    }
}
