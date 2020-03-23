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

        //FeedBack Report
        public HttpResponseMessage Get()
        {

            var data = (from qst in db.Question_tbl join
                        feed in db.Feedback_tbl on
                        qst.Id equals feed.QuestionID
                        select new FeedReport
                        {
                            Question = qst.Question,
                            FeedBack = feed.FeedBack,
                            UserID = feed.UserID
                        }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //Post FeedBack
        public HttpResponseMessage Post(Feedback_tbl feeds)
        {
            var data = db.Feedback_tbl.Add(feeds);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
