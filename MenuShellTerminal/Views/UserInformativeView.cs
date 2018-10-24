using Services;
using System;

namespace MenuShellTerminal.Views
{
    public class UserInformativeView : View
    {
        public override View ViewIt()
        {
            Console.Clear();
            Console.WriteLine($"-----{Globals.UserToView.UserName}-----");
            Console.WriteLine("(D)elete");
            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.D:
                    return new DeleteUserView(Globals.UserToView.UserName);
            }
            return this;
        }
    }
}
