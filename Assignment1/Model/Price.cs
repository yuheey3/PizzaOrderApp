//June7,2021
//Yuki Waka
//141082180
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
       
      
    }
}
