using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public static class Course_WeekDB
    {

        //get full Course_Weeklist of database
        public static List<Course_Week> GetFullCourse_Weeklist()
        {
            List<Course_Week> Course_Weeklist = new List<Course_Week>();

            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Course_Week ORDER BY Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Course_Week s_course = new Course_Week((int)dr[0], (int)dr[1], dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                            Course_Weeklist.Add(s_course);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Course_Weeklist;
        }

    }
}
