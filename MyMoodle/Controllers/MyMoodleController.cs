using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMoodle.Controllers
{
    public class MyMoodleController : Controller
    {



        // GET: MyMoodle
        public ActionResult Index(int loggedid)
        {

            //get courses of logged user
            List<Course> courselist = CourseManager.GetFullCourselist();
            List<Student_Course> student_courselist = Student_CourseManager.GetFullStudent_Courselist();
            List<Course> returncourselist = new List<Course>();
            foreach (Student_Course sc in student_courselist)
            {
                if (sc.StudentId == loggedid)
                {
                    foreach (Course c in courselist)
                    {
                        if (c.CourseId == sc.CourseId)
                        {
                            returncourselist.Add(c);
                        }
                    }
                }
            }

            ViewBag.loggedid = loggedid;

            return View(returncourselist);
        }

        public ActionResult ViewCourses (int loggedid)
        {
            List<Course> courselist = CourseManager.GetFullCourselist();
            List<Student_Course> student_courselist = Student_CourseManager.GetFullStudent_Courselist();
            foreach (Student_Course sc in student_courselist)
            {
                if (sc.StudentId == loggedid)
                {
                    //fillters out courses that a student is already enrolled
                    for (int i = courselist.Count - 1; i >= 0; i--)
                    {
                        if (courselist[i].CourseId == sc.CourseId)
                        {
                            courselist.RemoveAt(i);
                        }
                    }

                }
            }

            ViewBag.loggedid = loggedid;
            return View(courselist);
        }

        public ActionResult CreateStudentCourse(int courseid, int loggedid)
        {
            Student_CourseManager.newStudent_Course(loggedid, courseid);
            return RedirectToAction("Index", "MyMoodle", new { loggedid=loggedid });
        }

        public ActionResult ViewStudentCourse(int courseid, int loggedid)
        {
            List<Course_Week> course_weeklist = Course_WeekManager.GetFullCourse_Weeklist();

            //fillters out courses_week which are not corresponded to given courseid
            for (int i = course_weeklist.Count - 1; i >= 0; i--)
            {
                if (course_weeklist[i].CourseId != courseid)
                {
                    course_weeklist.RemoveAt(i);
                }
            }
            //get coursename from courseid and add to viewbag
            Course c = CourseManager.getObjectById(courseid);
            ViewBag.coursname = c.Title;
            ViewBag.coursenumber = c.Coursenumber;

            ViewBag.loggedid = loggedid;
            return View(course_weeklist);
        }

        public ActionResult DeleteStudentCourse(int courseid, int loggedid)
        {

            Student_CourseManager.deleteStudent_Course(loggedid, courseid);            
            return RedirectToAction("Index", "MyMoodle", new { loggedid = loggedid }); 
        }

    }
}