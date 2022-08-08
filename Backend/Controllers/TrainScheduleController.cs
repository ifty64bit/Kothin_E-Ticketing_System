using Business_Logic.Services;
using BusinessLogic.BOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.Controllers
{
    public class TrainScheduleController : ApiController
    {
        [Route("api/train_schedule/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Train_ScheduleServices.GetAll());
        }

        [Route("api/train_schedule/{id}")]
        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            var data = Train_ScheduleServices.GetById(id);
            if (data == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            else
                return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/train_schedule/create")]
        [HttpPost]
        public HttpResponseMessage Create(Train_ScheduleModel t)
        {
            var res = Train_ScheduleServices.Create(t);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [Route("api/train_schedule/update")]
        [HttpPost]
        public HttpResponseMessage Update(Train_ScheduleModel t)
        {
            var res = Train_ScheduleServices.Update(t);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }

        [Route("api/train_schedule/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(Train_ScheduleModel t)
        {
            var res = Train_ScheduleServices.Delete(t.Id);
            return Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}
