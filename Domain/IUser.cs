namespace Domain
{
    public interface IUser
    {

        void Init(string userName, string passWord, UserType userType);
        bool PassWordPass(string passWord);

    }
}
