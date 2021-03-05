using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class ChzPizza : APizza
    {
        public override string ToString()
        {
            return Name;
        }
    }
}