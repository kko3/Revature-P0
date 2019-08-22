using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Location
    {
      public List<Order> CurrentOrders { get; set; }
      public decimal Sales { get; set; }

      public string LocationName { get; set; }

      public List<User> CurrentUsers { get; set; }

      public Dictionary<string,int> Inventory { get; set; }

    }
}

