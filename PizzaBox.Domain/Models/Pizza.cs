using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public Crust PizzaCrust { get; set; }
    public Size PizzaSize { get; set; }

    public List<Topping> PizzaToppings { get; set; }

    public decimal Cost { get; set; }

    public int AmountOfToppings { get; set; }
  }
}