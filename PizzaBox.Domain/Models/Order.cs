using System;
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

        public decimal CalculateCost()
        {
          if(Pizzas.Count != 0){
            decimal totalpizzacost = 0;
            foreach (var p in Pizzas)
            {
              totalpizzacost += p.Cost;  
            }

            return totalpizzacost;
          }

          return -1;
        }

        public void ViewPizza()
        {
          foreach (var p in Pizzas)
          {
              Console.WriteLine(p);
          }
        }        
        
      public Order(){

        IsOrderComplete = false;
        PizzaLimit = 100;
        CostLimit = 5000;
      }
    }
}