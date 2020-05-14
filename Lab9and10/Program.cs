using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace CodeFirstModel
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentContext db = new StudentContext();

            /* Student std = new Student();
             std.Name = "Mubashir Hussain";

             Subject mathsub = new Subject { Name = "Mathematics"};
             Subject softwareSub = new Subject { Name = "Software Engineering"};

             std.Subjects.Add(mathsub);
             std.Subjects.Add(softwareSub);

             db.Students.Add(std);
             db.SaveChanges();*/

            /* Student std = new Student();
             std.Name = "John";
             Subject IRsubj = new Subject();
             IRsubj.Name = "International Relations";
             IRsubj.Student = std;
             db.Subjects.Add(IRsubj);
             db.SaveChanges();*/

            var qry = from x in db.Students select x;
            foreach (Student s in qry) { Console.WriteLine(s.Name + " " + s.StudentId); }
            Console.ReadLine();

        }
    }

    public class Student
    {
        
        public int StudentId { get; set; }
        public string Name { get; set; }

        public virtual List<Subject> Subjects { get; set; }
        public Student(){
            this.Subjects = new List<Subject>();
    }
}

    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }

        public virtual Student Student { get; set; }
    }

    public class StudentContext : DbContext
        {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
