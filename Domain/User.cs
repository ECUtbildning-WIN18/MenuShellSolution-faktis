using System;
using System.Security.Cryptography;

namespace Domain
{
    public abstract class User : IUser
    {
        public string UserName { get; private set; }      
        public UserType UserType { get; private set; }
        private string passWord;
        public string SaltHashPassWord { get; private set; }
        
        public User( string userName , string passWord , UserType userType)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(passWord, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            SaltHashPassWord = Convert.ToBase64String(hashBytes);
            Init( userName , SaltHashPassWord, userType);
        }

        public void Init( string userName, string passWord, UserType userType)
        {
            UserName = userName;
            this.passWord = passWord;
            UserType = userType;
        }

        public bool PassWordPass( string passWord )
        {
                string savedPasswordHash = this.passWord;
                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(passWord, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        return false;
                return true;
        }
    }
}
