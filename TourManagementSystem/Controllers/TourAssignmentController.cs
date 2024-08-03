using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TourManagementSystem.Controllers
{
    public class TourAssignmentController : ApiController
    {
        [HttpGet]
        [Route("api/TourAssignment")]
        public HttpResponseMessage TourAssignment()
        {
            try
            {
                var data = TourAssignmentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/TourAssignment/{id}")]
        public HttpResponseMessage Tour(int id)
        {
            try
            {
                var data = TourAssignmentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
