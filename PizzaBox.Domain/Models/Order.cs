using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set; }
        public decimal Cost { get; set; }

        public static decimal CostLimit { get; set; }
        public static int PizzaLimit { get; set; }

        public bool IsOrderComplete { get; set; }
        
        
      public Order(){

        IsOrderComplete = false;
        CostLimit = 5000;
        PizzaLimit = 100;
      }
    }
}