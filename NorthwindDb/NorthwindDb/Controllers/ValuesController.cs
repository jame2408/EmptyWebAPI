using NorthwindDb.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace NorthwindDb.Controllers
{
    public class ValuesController : ApiController
    {
        // GET: api/Values
        public HttpResponseMessage Get()
        {
            //return new string[] { "value1", "value2" };
            var resp = Request.CreateResponse(HttpStatusCode.OK, "value");
            resp.Content = new StringContent("Hello", Encoding.Unicode);
            resp.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(20)
            };

            return resp;
        }

        // GET: api/Values/5
        [ApiError]
        public string Get(int id)
        {
            throw new NotImplementedException();

            return "value";
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }
    }
}
