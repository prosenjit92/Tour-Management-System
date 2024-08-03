using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TourManagementSystem.Controllers
{
    public class LocationController : ApiController
    {
        [HttpPost]
        [Route("api/location")]
        public HttpResponseMessage CreateLocation(LocationDTO locationDTO)
        {
            try
            {
                LocationService.Create(locationDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Location created successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/location/{id}")]
        public HttpResponseMessage UpdateLocation(int id, LocationDTO updatedLocation)
        {
            try
            {
                // Assuming you want to return the updated location
                var data = LocationService.Update(updatedLocation);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
