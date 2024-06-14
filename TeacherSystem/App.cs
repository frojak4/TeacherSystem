using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSystem
{
    internal class App
    {
        
        bool loggedIn = false;
        public Registry userlist = new Registry();

        public IUser currentUser;

        public void Run()
        {
            logIn();
            currentUser.mainMenu();
        }

        private void logIn()
        {
            
            while (!loggedIn){
                Console.Clear();
                Console.WriteLine("What's your username?");
                string username = Console.ReadLine();
                Console.WriteLine("What's your password?");
                string password = Console.ReadLine();

                

                foreach (var user in userlist.getUserList())
                {
                    
                    if (username == user.getUserName())
                    {
                        if (password == user.getPassword())
                        {
                            Console.Clear();
                            Console.WriteLine("Successfully logged in.");
                            loggedIn = true;
                            currentUser = user;
                        
                            Console.ReadKey();
                        } else {Invalid();}
                    }
                    else
                    {Invalid();}
                }

            }
        }

        private void Invalid()
        {
            Console.WriteLine("Invalid username or password");
            Console.ReadKey();
            
        }
    }
}
