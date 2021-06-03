using System;
namespace Assignment1.Model
{
    public class Topping
    {
        private string _name;
        private double _price;
      

        public string name //backing fields
        {
            get { return _name; }
            set { _name = value; }

        }

        public double price //backing fields
        {
            get { return price; }
            set { _price = value; }

        }




        public Topping(string n, double p)
        {
            this.name = n;
            this.price = p;
            
        }

    }
}
