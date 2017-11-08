namespace StudentAppAdo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Marks = new HashSet<Mark>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        public string SecondName { get; set; }

        public int? Age { get; set; }

        public int? City { get; set; }

        [StringLength(250)]
        public string PhoneNumber { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(250)]
        public string Street { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        public int? University { get; set; }

        [StringLength(250)]
        public string Speciality { get; set; }

        public int? NumberCourse { get; set; }

        public virtual City City1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mark> Marks { get; set; }

        public virtual University University1 { get; set; }
    }
}
