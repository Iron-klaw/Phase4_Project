using NUnit.Framework;
using System.Collections.Generic;
using JoePizza;
using JoePizza.Models;

namespace JoeNunit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        PizzaBO _context = new PizzaBO();
        [Test]
        public void GetAllPizzas()
        {
            List<Pizza> ExpectedPizzaList = new List<Pizza>
            {
                new Pizza{Id=1001, PizzaType="Cheese N Corn", cost=50, Toppings=false,Quantity=20},
                new Pizza{Id=1002, PizzaType="Peppy Paneer", cost=60, Toppings=false,Quantity=30},
                new Pizza{Id=1003, PizzaType="Mexican Green Wave", cost=70, Toppings=false,Quantity=80},
                new Pizza{Id=1004, PizzaType="Veg Extravaganza", cost=150, Toppings=false,Quantity=50},
            };
            List<Pizza> acutalPizzaList = _context.getAllPizza();
            Assert.AreEqual(acutalPizzaList, ExpectedPizzaList);
        }
        [Test]
        public void GetPizzaById()
        {
            Pizza ExpectedPizza = new Pizza { Id = 1001, PizzaType = "Cheese N Corn", cost = 50, Toppings = false, Quantity = 20 };
            Pizza acutalPizza = _context.getPizzaById(1001);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
        }
        [Test]
        public void Order()
        {
            Pizza ExpectedPizza = new Pizza { Id = 1001, PizzaType = "Cheese N Corn Pizza", cost = 50, Toppings = false, Quantity = 20 };
            _context.order(ExpectedPizza);
            Pizza acutalPizza = _context.getPizzaById(1001);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
        }
    }
}