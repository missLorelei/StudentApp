using StudApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudApp.Models
{
    public class Student : Person
    {

        public List<Mark> Marks;
        public string Speciality { get; set; }
        public int NumberCourse { get; set; }
    }
}