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
        FeedBackSystemEntities2 db = new FeedBackSystemEntities2();
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

            var data = (from adm in db.Admin_tbl
                       where adminID == adm.AdminName && adminpass == adm.Password
                       select new AdminLog {
                           Id = adm.Id,
                           Admin = adm.AdminName,
                           Password = adm.Password
                       }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
