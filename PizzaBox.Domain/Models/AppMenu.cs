using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class AppMenu
  {
    public void AppStart()
    {
      User u = new User();
      List<Location> listoflocations = new List<Location>();

      Menu(u,listoflocations);
    }
    public void Menu(User u,List<Location> lol)
    {
      string accountsignedin;
      int choice = -1;
      bool quit = false;



      while(!quit){
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
            Console.WriteLine("Already logged in");
          }
        }
        else if(choice == 2)
        {
          u = u.CreateLogin();
        }
        else if(choice == 3)
        {
          if(u.AccountName == "None"){
            Console.WriteLine("Please log in or create an Account.");
          }
          else
          {
            u.PlaceOrder(lol,u);
          }
        }
        else{
          quit = true;
        }
      }
    }
  }
}