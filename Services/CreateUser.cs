using System.Xml.Linq;
using Domain;

namespace Services
{
    public class CreateUser
    {
        public string TryCreate(string userName, string passWord, string userType)
        {

            if (!Database.UserNames.Contains(userName))
            {
                if (userType == "Customer")
                {
                    Database.Users.Add(userName, new Customer(userName, passWord));
                    Database.UserNames.Add(userName);
                }
                else if(userType == "Admin")
                {
                    Database.Users.Add(userName, new SystemAdministrator(userName, passWord));
                    Database.UserNames.Add(userName);
                }
                XElement User =
                    new XElement("User",
                    new XElement("Name", userName),
                    new XElement("Type", userType),
                    new XElement("PassWord", Database.Users[userName].SaltHashPassWord));
                
                Database.UsersXML.Root.Add(User);
                Database.UsersXML.Save("Users.xml");
                return "Created";
            }
            else
            {
                return "User with given UserName already exist";
            }
        }
    }
}
