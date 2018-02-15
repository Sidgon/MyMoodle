using BLL;
using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyMoodle.Controllers
{
    public class Course_WeekRESTController : ApiController
    {

        public string Get()
        {
            List<Course_Week> course_weeklist = Course_WeekManager.GetFullCourse_Weeklist();
            var json = JsonConvert.SerializeObject(course_weeklist);

            return json;
        }

    }
}
