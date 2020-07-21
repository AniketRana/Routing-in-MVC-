using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traditional_Way_Rounting_in_mvc.Models;

namespace Traditional_Way_Rounting_in_mvc.Controllers
{
    [RoutePrefix("Students")]
    public class StudentController : Controller
    {
        [Route("")]
        // GET: Student
        public ActionResult GetAllStudents()
        {
            var data = Stud();
            return View(data);
        }

        [Route("{id:int:min(5)}")]
        public ActionResult GetStudent(int id)
        {
            var student = Stud().FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        [Route("{id}/Address")]
        public ActionResult GetStudentAddress(int id)
        {
            var student = Stud().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(student);
        }
        [Route("{id}")]
        public string Mystr(string id)
        {
            return id;
        }

        [Route("~/about-us")]
        [Route("~/aboutus")]
        public string aboutUs() 
        {
            return "This is a about us paage";
        }

        private List<Student> Stud()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    Name="Aniket",
                    Class = "Tenth",
                    Address = new Address()
                    {
                        Address1 ="This is student 1 address",
                        City = "surat",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=2,
                    Name="Anil",
                    Class = "Second",
                    Address = new Address()
                    {
                        Address1 ="This is student 2 address",
                        City = "Bardoli",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=3,
                    Name="Rahil",
                    Class = "third",
                    Address = new Address()
                    {
                        Address1 ="This is student 3 address",
                        City = "Mumbai",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=4,
                    Name="Jay",
                    Class = "five",
                    Address = new Address()
                    {
                        Address1 ="This is student 5 address",
                        City = "Navsari",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=5,
                    Name="Rahul",
                    Class = "one",
                    Address = new Address()
                    {
                        Address1 ="This is student 5 address",
                        City = "pune",
                        HomeNumber = "1234567890"
                    }
                },

                new Student()
                {
                    Id=6,
                    Name="Dev",
                    Class = "four",
                    Address = new Address()
                    {
                        Address1 ="This is student 6 address",
                        City = "Jaipur",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=7,
                    Name="Deep",
                    Class = "Second",
                    Address = new Address()
                    {
                        Address1 ="This is student 7 address",
                        City = "Baroda",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=8,
                    Name="Rushabh",
                    Class = "six",
                    Address = new Address()
                    {
                        Address1 ="This is student 8 address",
                        City = "Mumbai",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=9,
                    Name="Ronik",
                    Class = "eight",
                    Address = new Address()
                    {
                        Address1 ="This is student 9 address",
                        City = "Nashik",
                        HomeNumber = "1234567890"
                    }
                },
                new Student()
                {
                    Id=10,
                    Name="Ankit",
                    Class = "one",
                    Address = new Address()
                    {
                        Address1 ="This is student 10 address",
                        City = "Bangelor",
                        HomeNumber = "1234567890"
                    }
                },

            };
        }
    }
}