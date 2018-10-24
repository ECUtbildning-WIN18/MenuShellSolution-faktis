namespace Domain
{
    public class SystemAdministrator : User
    {
        public SystemAdministrator(string userName, string passWord) : base(userName, passWord, UserType.SystemAdministrator) { }
    }
}
