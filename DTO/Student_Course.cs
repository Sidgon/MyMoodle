using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student_Course
    {

        private int student_courseId;
        private int studentId;
        private int courseId;
        private string timestamp;

        public int Student_courseId
        {
            get
            {
                return student_courseId;
            }

            set
            {
                student_courseId = value;
            }
        }

        public int StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }

        public int CourseId
        {
            get
            {
                return courseId;
            }

            set
            {
                courseId = value;
            }
        }

        public string Timestamp
        {
            get
            {
                return timestamp;
            }

            set
            {
                timestamp = value;
            }
        }

        public Student_Course(int student_courseId, int studentId, int courseId, string timestamp)
        {
            this.student_courseId = student_courseId;
            this.studentId = studentId;
            this.courseId = courseId;
            this.timestamp = timestamp;
        }
    }
}
