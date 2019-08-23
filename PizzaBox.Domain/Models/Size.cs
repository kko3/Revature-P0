using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Models
{
  public class Size : IPizzaParts
  {
    public string Name { get; set; }
    public decimal Cost { get; set; }
  }
}