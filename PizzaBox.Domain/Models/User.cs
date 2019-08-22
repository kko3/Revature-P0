using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public List<Order> OrderHistory { get; set; }
    public string AccountName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Location SelectedLocation { get; set; }


    public User UserLogin(){
      User u = new User();

      string typedusername = "";
      string typedpassword = "";

      while( u.UserName != typedusername || u.Password != typedpassword)
      {
        typedusername = "";
        typedpassword = "";

        Console.WriteLine("What is your username?");
        typedusername = Console.ReadLine();

        Console.WriteLine("password?");
        typedpassword = Console.ReadLine();

        if(u.UserName != typedusername || u.Password != typedpassword)
        {
          Console.WriteLine();
          Console.WriteLine("Try Again");
        }
      }

      u.AccountName = "Test";
      Console.WriteLine("Good");
      return u;
    }
    public User UserLogOut(){
      User u = new User();

      return u;
    }

    public void ViewAccountDetails()
    {
      Console.WriteLine("In Account Details");
    }
    public void CreateLogin(){}
    public void SelectFromLocations(){}
    public void PlaceOrder(){}

    public User()
    {
      AccountName = "None";
      UserName = "username";
      Password = "password";
    }
  }
}