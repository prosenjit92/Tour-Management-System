using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TourManagementSystem.Controllers
{
    public class TravelerProfileController : ApiController
    { 
            [HttpGet]
            [Route("api/TravelerProfile/{id}")]
            public HttpResponseMessage TravelerProfile(int id)
            {
                try
                {
                    var data = TravelerProfileService.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
                }
            }
        

    }
}
