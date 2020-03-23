using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Feedbacksystem.Models;

namespace Feedbacksystem.Controllers
{
    public class QuestionController : ApiController
    {
        FeedBackSystemEntities db = new FeedBackSystemEntities();

        public HttpResponseMessage Get()
        {
            var data = (from qst in db.Question_tbl select qst.Question).ToList(); 
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }

        public HttpResponseMessage Post(Question_tbl quest)
        {
            var data = db.Question_tbl.Add(quest);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
