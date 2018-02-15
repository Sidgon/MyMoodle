using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {

        private int studentId;
        private string studentnumber;
        private string password;
        private string firstname;
        private string lastname;
        private string address;
        private string phonenumber;

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

        public string Studentnumber
        {
            get
            {
                return studentnumber;
            }

            set
            {
                studentnumber = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Phonenumber
        {
            get
            {
                return phonenumber;
            }

            set
            {
                phonenumber = value;
            }
        }

        public Student(int studentId, string studentnumber, string password, string firstname, string lastname, string address, string phonenumber)
        {
            this.studentId = studentId;
            this.studentnumber = studentnumber;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.phonenumber = phonenumber;
        }

        public Student()
        {
        }

    }
}
