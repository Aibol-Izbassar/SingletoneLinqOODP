using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Subject
    {
        protected string _name;
        protected Teacher _myTeacher;
        public List<Student> MyStudents = new List<Student>();
        
        public Subject(string Name)
        {
            _name = Name;
        }
        public string Name { get { return _name; } }
        public string TeacherName { get { return _myTeacher.Name; } }
       

        //Присвоение дисциплине только одного учителя
        public void SetTeacher(Teacher t)
        {
            if (_myTeacher == null)
            {
                _myTeacher = t;
            }
            else
            {
                
            }
        }
    }
}
