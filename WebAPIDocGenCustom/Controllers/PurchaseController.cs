using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDocGenCustom.Controllers
{
    public class PurchaseController : ApiController
    {
        // GET api/purchase
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/purchase/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/purchase
        public void Post([FromBody]string value)
        {
        }

        // PUT api/purchase/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/purchase/5
        public void Delete(int id)
        {
        }
    }
}
