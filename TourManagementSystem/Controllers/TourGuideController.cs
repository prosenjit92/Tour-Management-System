using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourManagementSystem.Models;

namespace TourManagementSystem.Controllers
{
    public class TourGuideController : ApiController
    {
        [HttpGet]
        [Route("api/TourGuide")]
        public HttpResponseMessage TourGuide()
        {
            try
            {
                var data = TourGuideService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/TourGuide/{id}")]
        public HttpResponseMessage TourGuide(int id)
        {
            try
            {
                var data = TourGuideService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/TourGuide/Login")]
        public HttpResponseMessage Login(LoginModel loginModel)
        {
            try
            {
                bool isAuthenticated = AuthService.Authenticate(loginModel.Username, loginModel.Password);

                if (isAuthenticated)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Login successful");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid credentials");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
