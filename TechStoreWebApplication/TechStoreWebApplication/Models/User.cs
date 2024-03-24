using System;

public class User
{
    //-------------------------
    //Constants:
    //-------------------------

    //-------------------------
    //Members:
    //-------------------------

    //-------------------------
    //Properties:
    //-------------------------
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    //-------------------------
    //Constructor/Destructor:
    //-------------------------

    public User(int ID, string username, string password, string email)
    {
        this.ID = ID;
        this.Username = username;
        this.Password = password;
        this.Email = email;
    }

    //-------------------------
    //Methods:
    //-------------------------

    //-------------------------
    //Overrides:
    //-------------------------
}