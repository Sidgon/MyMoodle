using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class StudentManager
    {

        //gets a full Student list
        public static List<Student> GetFullStudentlist()
        {
            return StudentDB.GetFullStudentlist();
        }
        //checks if input values are valid in database
        public static bool checkLogin(string username, string password)
        {
            bool correctlogin = false;
            List<Student> Studentlist = StudentDB.GetFullStudentlist();
            foreach (Student m in Studentlist)
            {
                if (m.Studentnumber == username && m.Password == password)
                {
                    correctlogin = true;
                    break;
                }

            }
            return correctlogin;
        }

        //returns the studentid with studentnumber input
        public static int getStudentId(string studentnumber)
        {
            return StudentDB.getStudentId(studentnumber);
        }

        // register new student
        public static bool newStudent(string studentnumber, string password,
            string firstname, string lastname, string address, string phonenumber)
        {
            return StudentDB.newStudent(studentnumber, password, firstname, lastname, address, phonenumber);
        }

    }
}
