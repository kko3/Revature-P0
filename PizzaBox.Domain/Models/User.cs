using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public List<Order> OrderHistory { get; set; }
    public string AccountName { get; set; }
    public Location SelectedLocation { get; set; }


    public User UserLogin(){
      User u = new User();

      Console.WriteLine("");

      return u;
    }
    public void UserLogOut(){}

    public void ViewAccountDetails(){}
    public void CreateLogin(){}
    public void SelectFromLocations(){}
    public void PlaceOrder(){}

    public User()
    {
      AccountName = "None";
    }
  }
}