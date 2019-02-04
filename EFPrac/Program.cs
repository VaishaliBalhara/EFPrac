using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPrac
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class SchoolContext:DbContext
    {
        public SchoolContext():base(@"Data Source =.\HUMBERBRIDGING; Initial Catalog = SCHOOL_DB; Integrated Security = True;")
        {

        }

        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }

    }
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

    }

    public class Teacher
    {
        [Key]
        public Guid SomeIdentifier { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }

}
