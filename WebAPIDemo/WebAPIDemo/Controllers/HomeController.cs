using System; using System.Collections.Generic; using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http; using Newtonsoft.Json;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers {     [RoutePrefix("api/home")]     public class HomeController : ApiController     {         public static List<Students> values = new List<Students>() {
            new Students(){Id=1, Name="Anil"},
            new Students(){Id=2, Name="Smile"},
            new Students(){Id=3, Name="Tiger"}
        };          [Route("getall")]         public IEnumerable<Students> Get()

        {
            var obj = new
            {
                Name = "Animalking",
                Age = 32
            };             string json = JsonConvert.SerializeObject(obj);             var toobj = JsonConvert.DeserializeObject(json);             return values;         }          [Route("{id:int}")]         //[Route("{id}/byid")]
        //[ActionName("GetGoing")]
        public Students Get(int id)          {             return values.FirstOrDefault(s=>s.Id==id);         }         [Route("{s1:alpha}")]         //[Route("{s1}/byname")]         [HttpGet]         public Students byname(string s1)
        {
            return values.FirstOrDefault(s => s.Name == s1);

        }         [HttpPost]         public HttpResponseMessage Insert(Students students)
        {
            values.Add(students);
            return Request.CreateResponse(HttpStatusCode.Created);
        }            //public void Post([FromBody]string newvalue)         //{         //    values.Add(newvalue);         //}         //public void Put(int id, [FromBody]string newvalue)         //{         //    values[id] = newvalue;         //}         //public void Delete(int id)         //{
        //    //
        //    //commit
        //    values.RemoveAt(id);         //}         //public void Delete1(int id)         //{
        //    //
        //    //commit
        //    values.RemoveAt(id);         //}     } }   