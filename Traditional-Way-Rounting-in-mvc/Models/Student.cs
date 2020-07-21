using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traditional_Way_Rounting_in_mvc.Models
{
    public class Student
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Class { get; set; } 
        public Address Address { get; set; }

    }
}