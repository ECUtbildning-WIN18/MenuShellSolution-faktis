using System;
using System.Threading;
using Services;

namespace MenuShellTerminal.Views
{
    class AddUserView : View
    {
        public override View ViewIt()
        {
            Console.Clear();
            Console.Title = "Add User";
            Console.WriteLine("UserName: ");
            Console.WriteLine("PassWord ");
            Console.WriteLine("UserType ");
            Console.SetCursorPosition(10, 0);
            var userName = Console.ReadLine();
            Console.SetCursorPosition(10, 1);
            var passWord = Console.ReadLine();
            Console.SetCursorPosition(10, 2);
            var userType = Console.ReadLine();
            Console.WriteLine("Is this correct? (Y)es or (N)o !!!");
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Y:
                    var create = new CreateUser();
                    var createMessage = create.TryCreate(userName, passWord, userType);
                    if (createMessage != "Created")
                    {
                        Console.WriteLine(createMessage);
                        Thread.Sleep(2000);
                        return this;
                    }
                    return new SystemAdministratorView();

                case ConsoleKey.N:
                    break;
            }
            return this;
        }
    
    }
}
