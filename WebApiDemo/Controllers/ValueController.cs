using System;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValueController : ApiController
    {
        public int[] Get()
        {
            return new int[] { 1, 2, 3, 4 };
        }
        public string Get(string id)
        {
            if (id == "smile" || id == "musi" || id == "snigdha")
            {
                return "I love You " + id;

            }
            return null;
        }

        public string Post(string id)
        {

            return id;
        }
    }
}
