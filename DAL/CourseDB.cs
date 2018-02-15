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
    public static class CourseDB
    {

        //get full Courselist of database
        public static List<Course> GetFullCourselist()
        {
            List<Course> Courselist = new List<Course>();

            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Course ORDER BY Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Course mem = new Course((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                            Courselist.Add(mem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Courselist;
        }

        //returns a Courseid with the Coursenumber as parameter 
        public static int getCourseId(string Coursenumber)
        {
            int CourseId = -1;
            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id FROM [Course] WHERE Coursenumber='" + Coursenumber + "'";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CourseId = (int)dr[0];
                        }
                    }
                    return CourseId;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }

        //inserts a new Course into database returns true if insert was succesfull
        public static bool newCourse(string coursenumber, string title, string teacher)
        {
            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO[Course]([Coursenumber], [Title], [Teacher], )" +
                        "VALUES(@Coursenumber, @Title, @Teacher)";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Coursenumber", coursenumber);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Teacher", teacher);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                System.Console.WriteLine("no error");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }


        //return course object by given id 

        public static Course getObjectById(int courseId)
        {
            Course courseObject = null;

            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [Course] WHERE Id=" + courseId;
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            courseObject = new Course((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                        }
                    }
                    return courseObject;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

    }
}
