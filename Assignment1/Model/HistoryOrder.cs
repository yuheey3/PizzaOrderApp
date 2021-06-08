//June7,2021
//Yuki Waka
//141082180
using System;
namespace Assignment1.Model
{
    public class HistoryOrder
    {
        private int _qty;
        private double _price;
        private string _dateTime;

        public int qty //backing fields
        {
            get { return _qty; }
            set { _qty = value; }

        }


        public double price //backing fields
        {
            get { return _price; }
            set { _price = value; }

        }

        public string dateTime //backing fields
        {
            get { return _dateTime; }
            set { _dateTime = value; }

        }

        public HistoryOrder(int q, double p, string d)
        {
            this.qty = q;
            this.price = p;
            this.dateTime = d;

        }

        public HistoryOrder()
        {
        }
    }
}