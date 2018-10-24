using Domain;
using Services;
using System;
using System.Threading;

namespace MenuShellTerminal.Views
{
    public class LoginView : View
    {
        public override View ViewIt()
        {
            Console.Clear();
            Console.Title = "Login";
            Console.WriteLine("UserName: ");
            Console.WriteLine("PassWord ");
            Console.SetCursorPosition(10, 0);
            var userName = Console.ReadLine();
            Console.SetCursorPosition(10, 1);
            var passWord = Console.ReadLine();
            Console.WriteLine("Is this correct? (Y)es or (N)o !!!");
            var key = Console.ReadKey().Key;
            Console.Clear();
            switch (key)
            {
                case ConsoleKey.Y:
                    var login = new Login();
                    var loginMessage = login.TryLogin(userName, passWord); 
                    if (loginMessage == "LogIn")
                    {

                        if(Globals.ActiveUser.UserType == UserType.SystemAdministrator)
                        {
                             return new SystemAdministratorView();
                        }
                        else if (Globals.ActiveUser.UserType == UserType.Customer)
                        {
                            return new CustomerView();
                        }
                    }
                    else
                    {
                        
                        Console.WriteLine(loginMessage);
                        Thread.Sleep(2000);
                    }
                    break;
                case ConsoleKey.N:
                    break;
            }
            return this;
        }
    }
}
