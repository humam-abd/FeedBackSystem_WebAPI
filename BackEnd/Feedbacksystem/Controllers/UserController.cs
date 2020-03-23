using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text.RegularExpressions;
using Feedbacksystem.Models;

namespace Feedbacksystem.Controllers
{
    public class UserController : ApiController
    {
        FeedBackSystemEntities db = new FeedBackSystemEntities();
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

        public HttpResponseMessage Get(string adminID, string adminpass)
        {
            var data = (from admin in db.Admin_tbl
                       select db.Admin_tbl).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
