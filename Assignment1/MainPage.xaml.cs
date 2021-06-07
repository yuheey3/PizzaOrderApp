using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Model;

using Xamarin.Forms;

namespace Assignment1
{
    public partial class MainPage : ContentPage


    {
        private string toppingLabel;
        private string sizeLabel;
        private string qtyLabel;
        private double pizzaPrice = 10;
        private double toppingPrice;
        private double sizePrice;
       
        Manager manager = new Manager();
        //Price price = new Price();


        public MainPage()
        {
           
            InitializeComponent();
            toppingList.ItemsSource = manager.toppings;
            sizeList.ItemsSource = manager.sizes;
            BindingContext = this;
            
         


        }

        public double getToppingPrice(Topping t)
        {
            return t.price;
        }

        public string ToppingLabel
             {
                get { return toppingLabel; }
                set
                {
                     toppingLabel = value;
                    OnPropertyChanged(nameof(ToppingLabel)); // Notify that there was a change on this property
                }
            }
        public string SizeLabel
        {
            get { return sizeLabel; }
            set
            {
                sizeLabel = value;
                OnPropertyChanged(nameof(SizeLabel)); // Notify that there was a change on this property
            }
        }
        public string QtyLabel
        {
            get { return qtyLabel; }
            set
            {
                qtyLabel = value;
                OnPropertyChanged(nameof(QtyLabel)); // Notify that there was a change on this property
            }
        }




        void addNewPizza(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Thank  You", "All DONE!!!", "OK");
        }
        void toppingList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            
            ToppingLabel = (e.SelectedItem as Topping).name;
            //toppingPrice = price.getToppingPrice(ToppingLabel);

            toppingPrice = (e.SelectedItem as Topping).price;
        }

        void sizeList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
           SizeLabel = (e.SelectedItem as PizzaSize).name;
           //sizePrice = price.getSizePrice(SizeLabel);
           sizePrice = (e.SelectedItem as PizzaSize).price;
        }

        void qtyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var btn = (Button)sender;
            QtyLabel = btn.Text;
           
        }

        void buyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            double total = 0;
            total = (pizzaPrice + toppingPrice + sizePrice) * Convert.ToInt32(QtyLabel);
            var mes = "Your order has now " + QtyLabel + " pizzas, and the total is " + total + " CAD";
            DisplayAlert("Success!!", mes, "OK");
        }
    }
}

