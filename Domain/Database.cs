using System.Collections.Generic;
using System.Xml.Linq;

namespace Domain
{
    public class Database
    {
        public static HashSet<string> UserNames { get; set; } = new HashSet<string>()
        { "Admin" , "Jake", "Jane", "Bane", "Insane" };

        public static Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
        public static XDocument UsersXML = XDocument.Load("Users.xml");
        public Database()
        {           
            Users.Add("Admin", new SystemAdministrator("Admin", "password"));
            Users.Add("Jake", new Customer("Jake", "password"));
            Users.Add("Jane", new Customer("Jane", "password"));
            Users.Add("Bane", new Customer("Bane", "password"));
            Users.Add("Insane", new Customer("Insane", "password"));
        }
    }
}