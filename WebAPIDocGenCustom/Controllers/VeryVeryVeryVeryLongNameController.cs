using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDocGenCustom.Controllers
{
    public class VeryVeryVeryVeryLongNameController : ApiController
    {
        // GET api/veryveryveryverylongname
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/veryveryveryverylongname/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/veryveryveryverylongname
        public void Post([FromBody]string value)
        {
        }

        // PUT api/veryveryveryverylongname/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/veryveryveryverylongname/5
        public void Delete(int id)
        {
        }
    }
}
