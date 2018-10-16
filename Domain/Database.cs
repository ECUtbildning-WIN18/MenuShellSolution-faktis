using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Domain;

namespace Domain
{
    public class Database
    {
        public static HashSet<string> UserNames { get; set; } = new HashSet<string>() { "Admin" };
        public static Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
        XDocument UsersXML = new XDocument();
        public Database()
        {
            
            Users.Add("Admin", new SystemAdministrator("Admin", "PassWord"));
            XElement User = new XElement("Users",
                new XElement("Admin",
                    new XElement("Name",Users["Admin"].UserName),
                    new XElement("PassWord", Users["Admin"].SaltHashPassWord)));
            UsersXML.Add(User);
            UsersXML.Save("Users.xml");
        }
    }
}