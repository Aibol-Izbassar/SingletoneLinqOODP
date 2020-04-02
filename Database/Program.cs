using System;
using System.Collections.Generic;
using System.Linq;
namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {

            Database db = Database.GetInstance();

            Teacher t = new Teacher("Rynat", 1);
            Teacher t2 = new Teacher("Maksim", 2);
            Teacher t3 = new Teacher("Maksat", 3);

            db.AddTeacher(t);
            db.AddTeacher(t2);
            db.AddTeacher(t3);

            Subject Mathem = new Subject("Mathematic");
            Subject Bio = new Subject("Biology");

            Mathem.SetTeacher(t);
            Bio.SetTeacher(t2);

            Bio.SetTeacher(t); //повторное присвоение не будет

            Student s = new Student("Aibol", 1);
            Student s1 = new Student("Ermek", 2);
            Student s2 = new Student("Maksim", 3);
            Student s3 = new Student("Elena", 4);
            Student s4 = new Student("Rynat", 5);

            db.AddStudent(s);
            db.AddStudent(s1);
            db.AddStudent(s2);
            db.AddStudent(s3);
            db.AddStudent(s4);

            db.AssignStudentToSubject(Bio, s);
            db.AssignStudentToSubject(Bio, s1);
            db.AssignStudentToSubject(Bio, s2);
            db.AssignStudentToSubject(Bio, s3);
            db.AssignStudentToSubject(Bio, s);

            Console.WriteLine(db.AboutSubject(Bio));//info о дисциплине

            //LINQ вывод одинаковых имен учителей и студентов
            var res1 = from table in db.Teachers
                       select table.Name;
            var res2 = from table in db.Students
                       select table.Name;

            var res = res2.Intersect(res1);
                     
            foreach (var item in res)
            {
                Console.WriteLine("Повторяется имя: " + item);
            }
           
        }
    }
}
