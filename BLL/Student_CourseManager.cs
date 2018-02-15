using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public static class Student_CourseManager
    {

        //gets a full Student_Course list
        public static List<Student_Course> GetFullStudent_Courselist()
        {
            return Student_CourseDB.GetFullStudent_Courselist();
        }

        public static bool newStudent_Course(int studentid, int courseid)
        {
            return Student_CourseDB.newStudent_Course(studentid, courseid);
        }

        public static bool deleteStudent_Course(int studentid, int courseid)
        {
            return Student_CourseDB.deleteStudent_Course(studentid, courseid);
        }

    }
}
