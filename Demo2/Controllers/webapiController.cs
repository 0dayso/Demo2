using Demo2BAL;
using Demo2Entity.wsclass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo2.Controllers
{
    public class webapiController : ApiController
    {
        // GET api/<controller>
       
        // GET api/<controller>/5
        public string Get(int id)
        {
            string str = "asdfasdfasdf asdfasfd";

            return str;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

    }
}