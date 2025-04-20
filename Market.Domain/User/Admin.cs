
using Application.Domain;

public class Admin : Account
{
    private static Admin _instance;

    public static Admin GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Admin("Mohammad","1234","mohammad.a.1384.per@gmail.com");
        }

        return _instance;
    }
    private Admin(string username, string password, string email) : base(username, password, email)
    {
    }
}