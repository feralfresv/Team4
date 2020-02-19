using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class WebApiController : ApiController
    {
        Models.Team4RMEntities BD = new Models.Team4RMEntities();
        [HttpPost]
        public HttpResponseMessage Post([FromBody]Models.Log TYT)
        {
            using (Models.Team4RMEntities BD = new Models.Team4RMEntities())
            {
                BD.Log.Add(TYT);
                BD.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.Created, TYT);
        }
    }
}
