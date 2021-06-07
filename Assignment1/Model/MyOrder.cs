using System;
namespace Assignment1.Model
{
    public class MyOrder
    {

        private int _qty;
        private string _topping;
        private string _size;
        private double _price;


     

        public int qty //backing fields
        {
            get { return _qty; }
            set { _qty = value; }

        }
        public string topping //backing fields
        {
            get { return _topping; }
            set { _topping = value; }

        }
        public string size //backing fields
        {
            get { return _size; }
            set { _size = value; }

        }
        public double price //backing fields
        {
            get { return _price; }
            set { _price = value; }

        }

        public void addMyOrder(String t, String s, int q, double p)
        {
            this.topping = t;
            this.size = s;
            this.qty = q;
            this.price = p;
        }


        public MyOrder(string t, string s, int q, double p)
        {
 
            this.topping = t;
            this.size = s;
            this.qty = q;
            this.price = p;
        }

        public MyOrder()
        {
        }
    }
}