using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TourManagementSystem.Controllers
{
    public class TourController : ApiController
    {
        [HttpGet]
        [Route("api/tours")]
        public HttpResponseMessage Tour()
        {
            try
            {
                var data = TourService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/tours/{id}")]
        public HttpResponseMessage Tour(int id)
        {
            try
            {
                var data = TourService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
