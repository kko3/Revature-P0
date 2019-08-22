using System;

namespace PizzaBox.Domain.Models
{
  public class AppMenu
  {
    public void AppStart()
    {
      User u = new User();
      Location l = new Location();

      Menu(u);
    }
    public void Menu(User u)
    {
      string accountsignedin;
      int choice = -1;

      accountsignedin = u.AccountName;

      do{
        Console.WriteLine($"                                            Current User: " + accountsignedin);
        Console.WriteLine();
        Console.WriteLine("Welcome To PizzaBox!!!");
        Console.WriteLine("1. Login to Account.");
        Console.WriteLine("2. Create an Account.");
        Console.WriteLine("3. Order");
        Console.WriteLine("4. Quit");
        Console.Write("(1-4)? ");
        choice = Convert.ToInt32(Console.ReadLine());
      }while(choice < 1 || choice > 4);

      if(choice == 1)
      {
        if(u.AccountName == "None")
        {
          u = u.UserLogin();
        }
        else
        {
          u.ViewAccountDetails();
        }
      }
      else if(choice == 2)
      {
        u.CreateLogin();
      }
      else if(choice == 3)
      {
        if(u.AccountName == "None"){
          Console.WriteLine("Please log in or create an Account.");
          Menu(u);
        }
        else
        {
          u.PlaceOrder();
        }
      }
    }
  }
}