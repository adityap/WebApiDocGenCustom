using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDocGenCustom.Controllers
{
    public class VeryLongNameController : ApiController
    {
        // GET api/verylongname
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/verylongname/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/verylongname
        public void Post([FromBody]string value, string test)
        {
        }

        // PUT api/verylongname/5
        public void Put(int id, [FromBody]string value, string test1, string test2)
        {
        }

        // DELETE api/verylongname/5
        public void Delete(int id)
        {
        }
    }
}
