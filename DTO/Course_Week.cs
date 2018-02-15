using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Course_Week
    {

        private int course_weekId;
        private int courseId;
        private string date;
        private string title;
        private string week_objective;
        private string description;

        public int Course_weekId
        {
            get
            {
                return course_weekId;
            }

            set
            {
                course_weekId = value;
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

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
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

        public string Week_objective
        {
            get
            {
                return week_objective;
            }

            set
            {
                week_objective = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public Course_Week(int course_weekId, int courseId, string date, string title, string week_objective, string description)
        {
            this.course_weekId = course_weekId;
            this.courseId = courseId;
            this.date = date;
            this.title = title;
            this.week_objective = week_objective;
            this.description = description;
        }
    }
}
