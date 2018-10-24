using System;

namespace MenuShellTerminal.Views
{
    class SystemAdministratorView : View
    {
        public override View ViewIt()
        {
            Console.Clear();
            Console.Title = "SystemAdministrator";
            Console.WriteLine("-----Options-----");
            Console.WriteLine("(A)dd User");
            Console.WriteLine("(S)earch User");
            Console.WriteLine("(L)og Out");
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.A:
                    return new AddUserView();
                case ConsoleKey.S:
                    return new SearchUserView();
                case ConsoleKey.L:
                    return new LoginView();
            }
            return this;
        }
    }
}
