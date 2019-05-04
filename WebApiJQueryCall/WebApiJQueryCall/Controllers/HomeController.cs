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
                using (TharEntities con = new TharEntities())
                {
                    Bird bird = con.Birds.FirstOrDefault(x => x.ID == id);
                    if (bird != null)
                    {
                        return (Request.CreateResponse(HttpStatusCode.OK, bird));
                    }
                    else
                    {
                        return (Request.CreateErrorResponse(HttpStatusCode.NotFound, id.ToString() + " No Bird Found"));
                    }
                }
            }
            catch (Exception e)
            {
                return (Request.CreateErrorResponse(HttpStatusCode.BadRequest, e));
            }
        }
        [HttpPost]
        public HttpResponseMessage InsertBird([FromBody]IEnumerable<Bird> det)
        {
            using (TharEntities insertbird = new TharEntities())
            {
                if (det != null)
                {
                    foreach (var item in det)
                    {
                        insertbird.Birds.Add(item);


                    }
                    insertbird.SaveChanges();
                    return (Request.CreateResponse(HttpStatusCode.OK, "Added " + insertbird.Birds.Select(x => x.BirdName)));
                }
                else
                {
                    return (Request.CreateErrorResponse(HttpStatusCode.NotModified, "Unable to add row"));
                }
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdateBird(int id, [FromBody]Bird pakshi)
        {
            using (TharEntities te = new TharEntities())
            {
                Bird birddetails = te.Birds.FirstOrDefault(x => x.ID == id);
                birddetails.BirdName = pakshi.BirdName;
                birddetails.ScientificName = birddetails.ScientificName;
                birddetails.TypeOfBird = birddetails.TypeOfBird;
                te.SaveChanges();
            }
            return (Request.CreateResponse(HttpStatusCode.OK, "Row updated"));
        }
    }
}

