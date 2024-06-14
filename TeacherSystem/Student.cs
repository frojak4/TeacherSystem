using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSystem
{
    internal class Student : User
    {
        private List<Grade> grades;

        public Student(string name, string username, string password) : base(name, username, password)
        {
            grades = new List<Grade>();
        }

        public override void mainMenu()
        {
            Console.Clear();
            while(true){
                foreach (var grade in grades)
                {
                    Console.WriteLine($"{grade.getSubject()} \t\t {grade.getGrade()}");
                }

                Console.ReadKey(true);
            }
        }

        public List<Grade> getGrades()
        {
            return grades;
        }

        public void addGrade(Grade grade)
        {
            grades.Add(grade);
        }
    }
}
