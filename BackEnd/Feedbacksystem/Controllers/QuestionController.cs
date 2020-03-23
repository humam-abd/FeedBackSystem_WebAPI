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
    }
}
