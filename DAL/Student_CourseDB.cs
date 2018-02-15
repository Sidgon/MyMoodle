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
    public static class Student_CourseDB
    {

        //get full Student_Courselist of database
        public static List<Student_Course> GetFullStudent_Courselist()
        {
            List<Student_Course> Student_Courselist = new List<Student_Course>();

            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Student_Course ORDER BY Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Student_Course s_course = new Student_Course((int)dr[0], (int)dr[1], (int)dr[2], dr[3].ToString());
                            Student_Courselist.Add(s_course);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Student_Courselist;
        }

        //inserts a new Student_Course into database returns true if insert was succesfull
        public static bool newStudent_Course(int studentId, int courseId)
        {
            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO[Student_Course]([StudentId], [CourseId], [Timestamp])" +
                        "VALUES(@StudentId, @CourseId, @Timestamp)";

                    string timestamp = DateTime.Now.ToString();

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    cmd.Parameters.AddWithValue("@Timestamp", timestamp);
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


        //deletes a course from student dashboard
        public static bool deleteStudent_Course(int studentId, int courseId)
        {
            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Student_Course WHERE StudentId = @StudentId AND CourseId = @CourseId";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
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
    }
}
