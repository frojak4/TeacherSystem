using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSystem
{
    internal interface IUser
    {
        string getUserName();
        string getPassword();
        string getName();

        void mainMenu();

    }
}
