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

        void CalculateCost()
        {
          decimal totalpizzacost = 0;
          foreach (var p in Pizzas)
          {
            totalpizzacost += p.Cost;  
          }

          Cost = totalpizzacost;
        }        
        
      public Order(){

        IsOrderComplete = false;
        PizzaLimit = 100;
        CostLimit = 5000;
        CalculateCost();
      }
    }
}