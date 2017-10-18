using StudApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudApp.Models
{
    public class Teacher : Person
    {
        public string Cathedra { get; set; }
        public string Degree { get; set; }

    }
}