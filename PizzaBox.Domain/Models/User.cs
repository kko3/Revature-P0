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

      return u;
    }
    public User UserLogOut(){
      User u = new User();

      return u;
    }

    public User CreateLogin()
    {
      User u = new User();
      string typedusername = "";
      string typedpassword1 = "";
      string typedpassword2 = "";

      Console.WriteLine("What is your username?");
      typedusername = Console.ReadLine();
      do
      {
        Console.WriteLine("Password?");
        typedpassword1 = Console.ReadLine();
        Console.WriteLine("Reenter your Password.");
        typedpassword2 = Console.ReadLine();
      }while(typedpassword1 != typedpassword2);

      u.UserName = typedusername;
      u.AccountName = typedusername;
      u.Password = typedpassword1;


      return u;
    }
    public Location SelectFromLocations(List<Location> lol)
    {
      Location LocationChoice = new Location();
      int choice = -1;
      Console.WriteLine("What Location did you want to order from?");
      choice = Convert.ToInt32(Console.ReadLine());

      return LocationChoice;
    }

    public void PlaceOrder(List<Location> lol,User u)
    {
      Order o = new Order();

      u.SelectedLocation = SelectFromLocations(lol);

      OrderHistory.Add(o);
    }

    public User()
    {
      AccountName = "None";
      UserName = "username";
      Password = "password";
    }
  }
}