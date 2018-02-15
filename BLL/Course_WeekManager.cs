using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Course_WeekManager
    {

        //gets a full Course_Week list
        public static List<Course_Week> GetFullCourse_Weeklist()
        {
            return Course_WeekDB.GetFullCourse_Weeklist();
        }

    }
}
