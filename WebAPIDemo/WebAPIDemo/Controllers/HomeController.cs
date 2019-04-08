using System;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class HomeController:ApiController
    {
        public string Get()
        {
            return "Hello Called From Get()";
        }

        public string get(string id)
        {
            if (id=="Musi"||id=="Smile"||id=="Snigdha")
            {
                return "Love You " + id;
            }
            return "Hatasya Premika";
        }
       
    }
}
