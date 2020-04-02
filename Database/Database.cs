using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Database
    {
        private static Database _dbInstance;

        private Database()
        {

        }
        public List<Teacher> Teachers = new List<Teacher>();
        public List<Subject> Subjects = new List<Subject>();
        public List<Student> Students = new List<Student>();

        public static Database GetInstance()
        {
            if (_dbInstance == null)
                _dbInstance = new Database();
            return _dbInstance;
        }

        public void AddStudent(Student s)
        {
             Students.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            Teachers.Add(t); 
        }
        
        public void AddSubject(Subject sub)
        {
            Subjects.Add(sub);
        }

        //Добавление студента на дисциплину только один раз по ID студента
        public void AssignStudentToSubject(Subject sub, Student stud)
        {
            bool check = true;
            foreach (var item in sub.MyStudents)
            {
                if (stud.Id==item.Id)
                {
                    check = false;
                }
            }
            if (check)
            {
                sub.MyStudents.Add(stud);
            }
        }

        public string AboutSubject(Subject sub)
        {
            string result = "Дисциплина: " + sub.Name + 
                            "\nПреподаватель " + sub.TeacherName + 
                            "\nКоличество студентов " + sub.MyStudents.Count;
            return result;
        }



    }
}
