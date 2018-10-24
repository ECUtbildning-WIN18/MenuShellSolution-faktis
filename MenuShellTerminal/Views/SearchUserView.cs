using Services;
using System;

namespace MenuShellTerminal.Views
{
    public class SearchUserView : View
    {
        public override View ViewIt()
        {
            Console.Clear();
            Console.WriteLine("Search by username:\n");
            var searchFor = Console.ReadLine();
            SearchAndFind.GenerateListOfUserNames(searchFor);
            return new ListUserView();
        }
    }
}
