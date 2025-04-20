using System.ComponentModel.DataAnnotations;

namespace Application.Domain.User;

public class User : Account
{
    public User(string username, string password,string email) : base(username, password,email)
    {
    }

    [Key]
    public int Id { get; set; }
    
    
}