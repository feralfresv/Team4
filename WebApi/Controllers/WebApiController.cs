using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using LogDataAccess;

namespace WebApi.Controllers
{
    public class WebApiController : ApiController
    {
        
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Log log)
        {
            using (Team4RMEntities BD = new Team4RMEntities())
            {
                BD.Log.Add(log);
                BD.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.Created, log);
        }
    }
}
