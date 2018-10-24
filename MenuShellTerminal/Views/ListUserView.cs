using Services;
using System;

namespace MenuShellTerminal.Views
{
    public class ListUserView : View
    {
        public override View ViewIt()
        {
            Console.Clear();
            var iterator = 1;
            foreach (string user in Globals.SearchResults)
            {
                Console.WriteLine($"{iterator++}: {user}");

            }
            Console.WriteLine("Index of User to view: ");

            int indexOfUser = -1;
            if (int.TryParse(Console.ReadLine(), out indexOfUser))
            {
                Globals.UserToView = SearchAndFind.UserWithUserName(Globals.SearchResults[indexOfUser - 1]);
                return new UserInformativeView();
            }
            return new SystemAdministratorView();
        }
    }
}
