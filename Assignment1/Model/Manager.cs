//June7,2021
//Yuki Waka
//141082180
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assignment1.Model
{

    public class Manager
    {
        public List<Topping> toppings = new List<Topping>();
        public List<PizzaSize> sizes = new List<PizzaSize>();
        public ObservableCollection<MyOrder> myOrders = new ObservableCollection<MyOrder>();
        public List<HistoryOrder> historyOrders = new List<HistoryOrder>();
        public Price prices = new Price();

        //my order
        public void addMyOrderToList(MyOrder o)
        {
            myOrders.Add(o);
        }
        public void deletemyOrder(MyOrder o)
        {
            myOrders.Remove(o);
        }



        //price
        public void AddTotalPriceAndQty(double p, double q)
        {

            prices.totalPrice = p;
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

      
        public double calculatePizzaPrice(double topping, double size, int qty)
        {

            double price = (prices.pizzaPrice + topping + size) * qty;

            return price;
        }

        public string calculateTotalPrice(double price, int qty)
        {

            prices.totalPrice += price;
            prices.totalQty += qty;
            var mes = "Your order has now " + prices.totalQty + " pizzas, and the total is " + prices.totalPrice + " CAD";

            return mes;
        }
        public double getTotalPrice()
        {
            return prices.totalPrice;
        }
        public double getTotalQty()
        {
            return prices.totalQty;
        }


        //history order
        public void addHistoryOrder(HistoryOrder h)
        {
            historyOrders.Add(h);
        }


        //others
        public void initializeValue()
        {
            prices.totalPrice = 0;
            prices.totalQty = 0;
            myOrders.Clear();
        }

        public bool isQtyExist(string q)
        {
            if (q.Equals("0") || q.Equals("none"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public Manager()
        {
            toppings.Add(new Topping("Vegetables", 1.5));
            toppings.Add(new Topping("Meat balls", 2));
            toppings.Add(new Topping("Peperony", 3.5));
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