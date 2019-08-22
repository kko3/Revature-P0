using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set; }
        public decimal Cost { get; set; }
        public decimal CostLimit { get; set; }
        public int PizzaLimit { get; set; }
        
    }
}