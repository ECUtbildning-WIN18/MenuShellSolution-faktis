using System;
using Services;

namespace MenuShellTerminal.Views
{
    class CustomerView : View
    {
        public override View ViewIt()
        {
            Console.Clear();
            Console.Title = "Customer";
            Console.WriteLine($"-----{Globals.ActiveUser.UserName}-----");
            Console.WriteLine("(D)elete User");
            Console.WriteLine("(L)og Out");
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D:
                    return new DeleteUserView(Globals.ActiveUser.UserName);
                case ConsoleKey.L:
                    return new LoginView();
            }
            return this;
        }
    }
}

