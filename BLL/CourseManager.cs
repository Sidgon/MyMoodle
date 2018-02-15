using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public static class CourseManager
    {

        //gets a full Course list
        public static List<Course> GetFullCourselist()
        {
            return CourseDB.GetFullCourselist();
        }

        //returns the Courseid with Coursenumber input
        public static int getCourseId(string Coursenumber)
        {
            return CourseDB.getCourseId(Coursenumber);
        }

        //return Course object of id
        public static Course getObjectById(int courseid)
        {
            return CourseDB.getObjectById(courseid);
        }
    }
}
