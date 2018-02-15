using BLL;
using DTO;
using MyMoodle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMoodle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        
        //check login
        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(loginVM.Studentnumber +" "+ loginVM.Password);
                //Check in BLL
                bool isCorrect = StudentManager.checkLogin(loginVM.Studentnumber, loginVM.Password);

                if (!isCorrect)
                {
                    ModelState.AddModelError(string.Empty, "Invalid email or password");
                    return View(loginVM);
                }
                else
                {
                    //redirects to mainpage of the logged user with all his chats -> loggin was correct
                    return RedirectToAction("Index", "MyMoodle", new { loggedid = StudentManager.getStudentId(loginVM.Studentnumber) });
                }

            }
            return View(loginVM);
        } 

        //open register view
        public ActionResult Register()
        {
            return View();
        }

        
        //check input data from register from and create user if correct
        [HttpPost]
        public ActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                //check if username is unique
                bool checkusername = false;
                if (StudentManager.getStudentId(student.Studentnumber) == -1)
                {
                    checkusername = true;
                }
                if (!checkusername)
                {
                    ModelState.AddModelError(string.Empty, "Student with studentnumber: " + student.Studentnumber + " already exists");
                    return View(student);
                }
                else
                {
                    //Store newly registered user in database
                    StudentManager.newStudent(student.Studentnumber, student.Password, student.Firstname, student.Lastname, student.Address, student.Phonenumber);
                    return RedirectToAction("Login", "Home");
                }

            }
            return View(student);
        }
        
    }

}
