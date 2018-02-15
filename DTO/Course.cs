using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Course
    {

        private int courseId;
        private string coursenumber;
        private string title;
        private string teachername;

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

        public string Coursenumber
        {
            get
            {
                return coursenumber;
            }

            set
            {
                coursenumber = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Teachername
        {
            get
            {
                return teachername;
            }

            set
            {
                teachername = value;
            }
        }

        public Course(int courseId, string coursenumber, string title, string teachername)
        {
            this.courseId = courseId;
            this.coursenumber = coursenumber;
            this.title = title;
            this.teachername = teachername;
        }
    }
}
