using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMoodle.Controllers
{
    [TestClass]
    public class MyMoodleUnitTestsController : Controller
    {
        [TestMethod]
        public void TestCourselistViewData()
        {
            var controller = new MyMoodleController();
            var result = controller.ViewCourses(1) as ViewResult;
            List<Course> courselist = (List<Course>) result.ViewData.Model;
            Assert.AreEqual("BITE2356", courselist[0].Coursenumber);
            Assert.AreEqual("Multidisciplinary Software Project", courselist[0].Title);
            Assert.AreEqual("Juhani Välimäki", courselist[0].Teachername);
            Assert.AreEqual("BITE7896", courselist[1].Coursenumber);
            Assert.AreEqual("Thesis Seminar", courselist[1].Title);
            Assert.AreEqual("Juhani Välimäki", courselist[1].Teachername);
        }

        [TestMethod]
        public void TestCourse_WeekViewData()
        {
            var controller = new MyMoodleController();
            var result = controller.ViewStudentCourse(1, 1) as ViewResult;
            List<Course_Week> course_weeklist = (List<Course_Week>)result.ViewData.Model;
            Assert.AreEqual("18.8.2017", course_weeklist[0].Date);
            Assert.AreEqual("Introduction", course_weeklist[0].Title);
            Assert.AreEqual("Introduction to Maven & Spring Boot, First Spring Boot" +
               " Project, Controllers & Routing, Request parameters", course_weeklist[0].Week_objective);
        }

    }
}