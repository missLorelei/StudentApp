namespace StudentAppAdo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.City1)
                .HasForeignKey(e => e.City);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Teachers)
                .WithRequired(e => e.City1)
                .HasForeignKey(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.SecondName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Marks)
                .WithRequired(e => e.Student1)
                .HasForeignKey(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Marks)
                .WithRequired(e => e.Subject1)
                .HasForeignKey(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<University>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.University1)
                .HasForeignKey(e => e.University);

            modelBuilder.Entity<University>()
                .HasMany(e => e.Teachers)
                .WithRequired(e => e.University1)
                .HasForeignKey(e => e.University)
                .WillCascadeOnDelete(false);
        }
    }
}
