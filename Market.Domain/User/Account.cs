namespace Application.Domain;

public class Account
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Account(string username, string password,string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }
}