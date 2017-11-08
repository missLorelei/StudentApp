namespace StudentAppAdo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(250)]
        public string SecondName { get; set; }

        public int Age { get; set; }

        public int City { get; set; }

        [Required]
        [StringLength(250)]
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(250)]
        public string Street { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        public int University { get; set; }

        [Required]
        [StringLength(250)]
        public string Cathedra { get; set; }

        [Required]
        [StringLength(250)]
        public string Degree { get; set; }

        public virtual City City1 { get; set; }

        public virtual University University1 { get; set; }
    }
}
