using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Services
{
    public class DeleteUser
    {
        public void Delete(string userName)
        {
            Database.Users.Remove(userName);
            Database.UserNames.Remove(userName);
        }
    }
}
