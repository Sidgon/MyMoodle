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
    public class Student_CourseRESTController : ApiController
    {

        public string Get()
        {
            List<Student_Course> Student_Courselist = Student_CourseManager.GetFullStudent_Courselist();
            var json = JsonConvert.SerializeObject(Student_Courselist);

            return json;
        }

    }
}
