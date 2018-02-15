using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace MyMoodle.Controllers
{
    public class CourseRESTController : ApiController
    {

        public string Get()
        {
            List<Course> courselist = CourseManager.GetFullCourselist();
            var json = JsonConvert.SerializeObject(courselist);

            return json;
        }

    }
}
