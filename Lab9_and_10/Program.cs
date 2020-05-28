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

            /* var qry = from x in db.Students select x;
             foreach (Student s in qry) { Console.Write(s.Name, " ", s.StudentId," ");
                 foreach (Subject v in s.Subjects) { Console.Write(v.Name, " "); }
                 Console.Write('\n');
             }*/

            /*Student std = db.Students.Where(x => x.Name == "Mubashir Hussain").First();
            std.Name = "Sara";
            db.SaveChanges();*/

            //var qry = from x in db.Students where x.Name == "Mubashir Hussain" select x;
            //var qry = (from x in db.Students where x.Name == "Mubashir Hussain" select x).Count();
            //var qry = (from x in db.Students select x.StudentId).Sum();
            //var qry = (from x in db.Students select x.StudentId).Max();
            //var qry = (from x in db.Students select x.StudentId).Min();
            //var qry = (from x in db.Students select x.StudentId).Average();

            var qry = from x in db.Students orderby  x.Name descending select x;
            //Console.WriteLine(qry);
            foreach (Student s in qry) { Console.WriteLine(s.Name); }
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
