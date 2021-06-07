﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assignment1.Model
{

    public class Manager
    {
        public List<Topping> toppings = new List<Topping>();
        public List<PizzaSize> sizes = new List<PizzaSize>();
        public ObservableCollection<MyOrder> myOrders = new ObservableCollection<MyOrder>();
        public Price prices = new Price();

        public void addTopping(Topping t)
        {
            toppings.Add(t);
        }

       public void addMyOrderToList(MyOrder o)
        {
            myOrders.Add(o);
        }

        public void AddTotalPriceAndQty(double p, double q )
        {
       
            prices.totalPrice =p;
            prices.totalQty = q;
        }

        public void changeTotalQty(double q)
        {
            prices.totalQty -= q;
        }
        public void changeTotalPrice(double p)
        {
            prices.totalPrice -= p;
        }

        public void deletemyOrder(MyOrder o)
        {
            myOrders.Remove(o);
        }



        public Manager()
        {
            toppings.Add(new Topping("Vegetables", 1));
            toppings.Add(new Topping("Meat balls", 2));
            toppings.Add(new Topping("Peperony", 3));
            toppings.Add(new Topping("Mushrooms", 4));
            toppings.Add(new Topping("Extra cheese", 5));
            toppings.Add(new Topping("Sausage", 6));

            sizes.Add(new PizzaSize("Small", 2));
            sizes.Add(new PizzaSize("Medium", 3));
            sizes.Add(new PizzaSize("Large", 4));
            sizes.Add(new PizzaSize("Party", 6));
        }
    }
}