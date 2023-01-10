using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new Blogging())
        {
            // Create and save a new Blog
            Console.Write("Enter a name of a student: ");
            var name = Console.ReadLine();

            var student = new Students { Name = name };
            db.Students.Add(student);
            db.SaveChanges();

            // Display all students from the database
            var query = from Students in db.Students
                        orderby Students.Name
                        select Students;

            Console.WriteLine("All students in the database?:");
            foreach (var person in query)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }

    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public virtual List<Grades> grades { get; set; }
    }

    public class Grades
    {
        public int Id { get; set; }
        public int grades { get; set; }
     

        public int StudentId { get; set; }
        public virtual Students Students { get; set; }
    }

    public class Blogging : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
    }
}

