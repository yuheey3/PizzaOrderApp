using System;
namespace Assignment1.Model
{
    public class Price
    {
        private double _pizzaPrice = 10;
        private double _totalPrice = 0;
        private double _totalQty = 0;


        public double pizzaPrice //backing fields
        {
            get { return _pizzaPrice; }
            set { _pizzaPrice = value; }

        }

        public double totalPrice //backing fields
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }

        }

        public double totalQty //backing fields
        {
            get { return _totalQty; }
            set { _totalQty = value; }

        }
        public Price()
        {

        }
       
        public double calculatePizzaPrice(double topping, double size, int qty)
        {

            double price = (pizzaPrice + topping + size) * qty;

            return price;
        }

        public string calculateTotalPrice(double price, int qty)
        {

            totalPrice += price;
            totalQty += qty;
            var mes = "Your order has now " + totalQty + " pizzas, and the total is " + totalPrice + " CAD";

            return mes;
        }
    }
}
