using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
  public class Crust : IPizzaParts
  {
    public string Name { get; set; }
    public decimal Cost { get; set; }
  }
}