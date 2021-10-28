using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoePizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string PizzaType { get; set; }
        public int cost { get; set; }
        public bool Toppings { get; set; }
        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Pizza))
            {
                return false;
            }
            return (this.Id == ((Pizza)obj).Id)
                && (this.PizzaType == ((Pizza)obj).PizzaType) && (this.Quantity == ((Pizza)obj).Quantity) && (this.Toppings == ((Pizza)obj).Toppings)
                && (this.cost == ((Pizza)obj).cost);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ PizzaType.GetHashCode() ^ Quantity.GetHashCode() ^ Toppings.GetHashCode() ^ cost.GetHashCode();
        }
    }
}
