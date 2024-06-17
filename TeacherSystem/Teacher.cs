using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSystem
{
    internal class Teacher : User
    {
        private Registry userlist;

        public Teacher(string name, string username, string password, Registry UserList) : base(name, username, password)
        {
            userlist = UserList;
        }

        public override void mainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add grades");
                Console.WriteLine("2. Look at grades");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddGrade();
                        break;
                    case "2":
                        SeeGrades();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }


        private void SeeGrades()
        {
            foreach (var student in userlist.getStudents())
            {
                

                Console.WriteLine($"{student.getName()}:");

                foreach (var grade in student.getGrades())
                {
                    Console.WriteLine($"Subject: {grade.getSubject()} \t {grade.getGrade()}");
                }
            }

            Console.ReadKey(true);

        }

        private void AddGrade()
        {
            Console.Clear();
            Console.WriteLine("Which student would you want to add a grade to?");
            for (int i = 0; i < userlist.getStudents().Count; i++)
            {
                Console.WriteLine($"{i + 1}. {userlist.getStudents()[i].getName()}");
            }

            int userInput = Convert.ToInt32(Console.ReadLine());
            userInput--;
            Console.Clear();
            Console.WriteLine("What subject?");
            string subject = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What grade?");
            int grade = Convert.ToInt32(Console.ReadLine());
            Grade newgrade = new Grade(subject, grade);
            userlist.getStudents()[userInput].addGrade(newgrade);
        }

        

    }
}
