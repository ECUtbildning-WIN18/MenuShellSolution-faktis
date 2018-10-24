namespace Domain
{
    class NotDefined : User
    {
        public NotDefined(string userName = "NotDefined", string passWord = "NotDefined") : base(userName, passWord, UserType.NotDefined) { }
    }
}
