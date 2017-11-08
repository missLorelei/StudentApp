namespace StudentAppAdo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mark")]
    public partial class Mark
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double MarkValue { get; set; }

        public int Subject { get; set; }

        public int Student { get; set; }

        public virtual Student Student1 { get; set; }

        public virtual Subject Subject1 { get; set; }
    }
}
