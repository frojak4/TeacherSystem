using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSystem
{
    internal class Registry
    {
        private List<Teacher> _teachers = new List<Teacher>()
        {
            new Teacher("test", "test", "test")
        };

        private List<Student> _students = new List<Student>()
        {
            new Student("Hubert", "hubert69", "123"),
            new Student("Fridtjof", "6969", "420")
        };
        public List<IUser> getUserList()
        {
            var list = new List<IUser>();
            foreach (var user in _students)
            {
                list.Add(user);
            }

            foreach (var user in _teachers)
            {
                list.Add(user);
            }

            return list;
        }

        public List<Student> getStudents()
        {
            return _students;
        }

    }
}
