using StudApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudApp.Models
{
    public class Mark : BaseEntity
    {
        public double MarkValue { get; set; }
        public Student Student;
        public Subject Subject;
        //[Key]
        //[ForeignKey("Student")]
        //public int IdStudent { get; set; }

        //[Key]
        //[ForeignKey("Subject")]
        //public int IdSubject { get; set; }

    }
}