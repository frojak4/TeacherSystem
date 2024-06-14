using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSystem
{
    internal abstract class User : IUser
    {
        private string _name;
        private string _username;
        private string _password;


        public User(string name, string username, string password)
        {
            _name = name;
            _username = username;
            _password = password;
        }

        public string getUserName()
        {
            return _username;
        }

        public string getPassword()
        {
            return _password;
        }

        public string getName()
        {
            return _name;
        }

        public virtual void mainMenu()
        {
            Console.WriteLine("Error occurred.");
        }
    }
    }

