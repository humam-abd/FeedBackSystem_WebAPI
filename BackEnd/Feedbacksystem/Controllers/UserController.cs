using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text.RegularExpressions;

namespace Feedbacksystem.Controllers
{
    public class UserController : ApiController
    {
        public HttpResponseMessage Post(Int64 userID)
        {
            var input = userID.ToString();
            var length = input.Length;
            if(length == 10 || length == 12)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Login Successful");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Unauthorized");
            }
        }

        public HttpResponseMessage Post(string adminID, string adminpass)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
