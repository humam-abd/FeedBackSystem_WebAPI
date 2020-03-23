using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Feedbacksystem.Models;

namespace Feedbacksystem.Controllers
{
    public class FeedBackController : ApiController
    {
        FeedBackSystemEntities db = new FeedBackSystemEntities();

        public HttpResponseMessage Get()
        {
            var data = db.Feedback_tbl.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        
        public HttpResponseMessage Post(Feedback_tbl feeds)
        {
            var data = db.Feedback_tbl.Add(feeds);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
