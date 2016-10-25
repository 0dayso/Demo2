using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo2;

namespace Demo2.Controllers
{
    public class IpController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            //return CommonManager.GetIP(Request);
            return string.Empty;

        }
    }
}