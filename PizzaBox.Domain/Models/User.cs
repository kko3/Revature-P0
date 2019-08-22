using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public List<Order> OrderHistory { get; set; }
    public Location SelectedLocation { get; set; }


    public void UserLogin(){}
    public void CreateLogin(){}
  }
}