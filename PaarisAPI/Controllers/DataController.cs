using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PaarisAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaarisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET: api/<DataController>
        [HttpGet("GetProduct")]
        public string GetProduct()
        {
                
            //string path = System.Web.Hosting.HostingEnvironment.MapPath("~/model/data/products.json");
            try
            {
                using (StreamReader r = new StreamReader(@"model/data/products.json"))
                {
                    string json = r.ReadToEnd();
                //    string item = JsonConvert.DeserializeObject(json);
                    return json;
                }
            }
            catch(Exception ex)
            { }
            return new string("not avail");
          
        }
        [HttpGet("GetOrder")]
        public string GetOrder()
        {

            //string path = System.Web.Hosting.HostingEnvironment.MapPath("~/model/data/products.json");
            try
            {
                using (StreamReader r = new StreamReader(@"model/data/createOrder.json"))
                {
                    string json = r.ReadToEnd();
                    //    string item = JsonConvert.DeserializeObject(json);
                    return json;
                }
            }
            catch (Exception ex)
            { }
            return new string("not avail");

        }


        // GET api/<DataController>/5

        // POST api/<DataController>

        // PUT api/<DataController>/5

        // DELETE api/<DataController>/5

    }
}
