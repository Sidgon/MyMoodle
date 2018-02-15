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
    public static class StudentDB
    {

        //get full Studentlist of database
        public static List<Student> GetFullStudentlist()
        {
            List<Student> Studentlist = new List<Student>();

            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Student ORDER BY Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Student mem = new Student((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                            Studentlist.Add(mem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Studentlist;
        }

        //returns a Studentid with the studentnumber as parameter 
        public static int getStudentId(string Studentnumber)
        {
            int studentId = -1;
            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id FROM [Student] WHERE Studentnumber='" + Studentnumber + "'";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            studentId = (int)dr[0];
                        }
                    }
                    return studentId;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }

        //inserts a new student into database returns true if insert was succesfull
        public static bool newStudent(string studentnumber, string password,
            string firstname, string lastname, string address, string phonenumber)
        {
            try
            {
                ConnectionStringSettings css = ConfigurationManager.ConnectionStrings["MyMoodleDB"];
                string connectionString = css.ConnectionString;
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO[Student]([Studentnumber], [Password], [Firstname], [Lastname], [Address], [Phonenumber])" +
                        "VALUES(@Studentnumber, @Password, @Firstname, @Lastname, @Address, @Phonenumber)";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Studentnumber", studentnumber);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Firstname", firstname);
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phonenumber", phonenumber);
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

    }
}
