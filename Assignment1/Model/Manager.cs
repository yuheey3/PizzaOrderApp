using System;
using System.Collections.Generic;
namespace Assignment1.Model
{
    public class Manager
    {
        public List<Topping> toppings = new List<Topping>();
        public List<PizzaSize> sizes = new List<PizzaSize>();
        public List<MyOrder> myOrders = new List<MyOrder>();

        public void addTopping(Topping t)
    {
            toppings.Add(t);
    }
    public Manager()
    {
            toppings.Add(new Topping("Vegetables", 22));
            toppings.Add(new Topping("Meat balls", 23));
            toppings.Add(new Topping("Peperony", 24));
            toppings.Add(new Topping("Mushrooms", 24));

            sizes.Add(new PizzaSize("Large", 22));
            sizes.Add(new PizzaSize("Medium balls", 23));
            sizes.Add(new PizzaSize("Small", 24));
            sizes.Add(new PizzaSize("Party", 24));
        }
}
}