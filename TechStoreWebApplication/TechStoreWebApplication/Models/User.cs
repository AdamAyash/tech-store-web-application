using System;

public class User
{
    //-------------------------
    //Constants:
    //-------------------------
    public enum UserRole
    {
        User
    }

    //-------------------------
    //Members:
    //-------------------------

    //-------------------------
    //Properties:
    //-------------------------
    public int ID { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
    public string Email { get; set; }

    //-------------------------
    //Constructor/Destructor:
    //-------------------------

    public User(int ID, string name, string username, string password, UserRole role, string email)
    {
        this.ID = ID;
        this.Name = name;
        this.Username = username;
        this.Password = password;
        this.Role = role;
        this.Email = email;
    }

    //-------------------------
    //Methods:
    //-------------------------

    //-------------------------
    //Overrides:
    //-------------------------
}