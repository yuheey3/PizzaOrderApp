using System;
namespace Assignment1.Model
{
    public class Topping
    {
        private string _name;
        private int _price;
      

        public string name //backing fields
        {
            get { return _name; }
            set { _name = value; }

        }

        public int price //backing fields
        {
            get { return price; }
            set { _price = value; }

        }




        public Topping(string n, int p)
        {
            this.name = n;
            this.price = p;
            
        }

    }
}
