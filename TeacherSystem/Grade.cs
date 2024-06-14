using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSystem
{
    internal class Grade
    {
        private string _subject;
        private int _grade;

        public Grade(string subject, int grade)
        {
            _subject = subject;
            _grade = grade;
        }

        public string getSubject()
        {
            return _subject;
        }

        public int getGrade()
        {
            return _grade;
        }
    }
}
