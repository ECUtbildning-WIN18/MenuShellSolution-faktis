using Domain;
using System.Collections.Generic;

namespace Services
{
    public static class SearchAndFind
    {
        public static void GenerateListOfUserNames(string searchCriteria)
        {
            Globals.SearchResults = new List<string>();
            foreach (string userName in Database.UserNames)
            {
                var different = false;
                for (int i = 0; i < searchCriteria.Length; i++)
                {
                    if (userName.Length < i) break;

                    different = searchCriteria[i] != userName[i];

                    if (different) break;

                }
                if (!different) Globals.SearchResults.Add(userName);
            }
        }

        public static User UserWithUserName(string userName)
        {
            return Database.Users[userName];
        }
    }
}
