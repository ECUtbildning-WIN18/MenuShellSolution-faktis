using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public class CreateUser
    {
        public string TryCreate(string userName, string passWord)
        {

            if (!Database.UserNames.Contains(userName))
            {
                Database.Users.Add(userName, new Customer(userName, passWord));
                Database.UserNames.Add(userName);

                return "Created";
            }
            else
            {
                return "User with given UserName already exist";
            }
        }
    }
}
