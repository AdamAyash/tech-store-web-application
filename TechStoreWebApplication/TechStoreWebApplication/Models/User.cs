using System;


public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }


    public User (int id, string username, string password, string email)
    {
        Id = id;
        Username = username;
        Password = password;
        Email = email;
    }

    //public void PrintModelsInfo()
    //{
        //Console.WriteLine($"User ID: {Id}");
        //Console.WriteLine($"Username: {Username}");
        //Console.WriteLine($"Password: {Password}");
        //Console.WriteLine($"Email: {Email}");
    //}
        

}