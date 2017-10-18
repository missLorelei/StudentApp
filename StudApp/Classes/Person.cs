using StudApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudApp.Classes
{
    public abstract class Person : BaseEntity
    {
        public string FisrtName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        //[Key]
        //[ForeignKey("City")]
        //public int IdCity { get; set; }
        public City City;
        public string PhoneNumer { get; set; }
        public string BirthDate { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        //[Key]
        //[ForeignKey("University")]
        //public int IdUniversity { get; set; }

        public University University;


    }
}