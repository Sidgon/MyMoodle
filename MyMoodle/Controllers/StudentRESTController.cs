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
    public class StudentRESTController : ApiController
    {

        public string Get()
        {
            List<Student> Studentlist = StudentManager.GetFullStudentlist();
            var json = JsonConvert.SerializeObject(Studentlist);

            return json;
        }

    }
}
