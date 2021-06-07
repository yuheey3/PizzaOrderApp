using System;
namespace Assignment1.Model
{
    public class MyOrder
    {
        private string _totalPrice;
        private int _qty;
        private string _topping;
        private string _size;


        public string totalPrice //backing fields
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }

        }

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




        public MyOrder(string tp, int q, string t, string s)
        {
            this.totalPrice = tp;
            this.qty = q;
            this.topping = t;
            this.size = s;
        }

    }
}