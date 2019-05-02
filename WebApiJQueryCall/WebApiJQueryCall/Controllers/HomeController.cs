using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BirdsFacade;

namespace WebApiJQueryCall.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetAllBird()
        {
            try
            {
                using (TharEntities con = new TharEntities())
                {
                    return (Request.CreateResponse(HttpStatusCode.OK, con.Birds.ToList()));
                }
            }
            catch (Exception e)
            {
                return (Request.CreateResponse(HttpStatusCode.NotFound, e));
            }           
        }

        [HttpGet]
        public HttpResponseMessage GetBirdByName(int id)
        {
            try
            {
                using (TharEntities con= new TharEntities())
                {
                    Bird bird = con.Birds.FirstOrDefault(x => x.ID == id);
                    if (bird != null)
                    {
                        return (Request.CreateResponse(HttpStatusCode.OK, bird));
                    }
                    else
                    {
                        return (Request.CreateErrorResponse(HttpStatusCode.NotFound, id.ToString() + " not found"));
                    }
                }
            }
            catch (Exception e)
            {
                return (Request.CreateErrorResponse(HttpStatusCode.BadRequest, e));
            }
        }
    }
}
