using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoePizza.Models
{
    public class PizzaBO
    {
        public static List<Pizza> PizzaList = new List<Pizza>
            {
                new Pizza{Id=1001, PizzaType="Cheese N Corn", cost=50, Toppings=false, Quantity=20},
                new Pizza{Id=1002, PizzaType="Peppy Paneer", cost=60, Toppings=false, Quantity=30},
                new Pizza{Id=1003, PizzaType="Mexican Green Wave", cost=70, Toppings=false, Quantity=80},
                new Pizza{Id=1004, PizzaType="Veg Extravaganza", cost=150, Toppings=false, Quantity=50},
            };
        public PizzaBO()
        {

        }
        public List<Pizza> getAllPizza()
        {
            return PizzaList;
        }
        public Pizza getPizzaById(int id)
        {
            return PizzaList.Single(x => x.Id == id);
        }
        public void order(Pizza p)
        {
            Pizza indPizza = PizzaList.Single(x => x.Id == p.Id);
            int index = PizzaList.IndexOf(indPizza);
            PizzaList[index] = p;

        }
    }
}
