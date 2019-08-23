using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set; }
        public decimal Cost { get; set;}

        public decimal CostLimit {get;}
        public int PizzaLimit {get;}

        public bool IsOrderComplete { get; set; }
        
      public Order(){

        IsOrderComplete = false;
        PizzaLimit = 100;
        CostLimit = 5000;
      }
    }
}