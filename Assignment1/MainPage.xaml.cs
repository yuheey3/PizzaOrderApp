//June7,2021
//Yuki Waka
//141082180
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
        private string toppingLabel = "none";
        private string sizeLabel = "none";
        private string qtyLabel = "none";

        private double toppingPrice;
        private double sizePrice;

        Manager manager = new Manager();

        Price price = new Price();


        public MainPage(Manager m)
        {
            manager = m;
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
            toppingPrice = (e.SelectedItem as Topping).price;
        }

        void sizeList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            SizeLabel = (e.SelectedItem as PizzaSize).name;
            sizePrice = (e.SelectedItem as PizzaSize).price;
        }

        void qtyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var btn = (Button)sender;
            QtyLabel = btn.Text;

        }

        void buyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //when quantity is more than 0 
            if (manager.isQtyExist(QtyLabel))

            {
                //calculate single order of price
                double singleOrderPrice = manager.calculatePizzaPrice(toppingPrice, sizePrice, Convert.ToInt32(QtyLabel));

                //calculate total class and return string for messages
                var mes = manager.calculateTotalPrice(singleOrderPrice, Convert.ToInt32(QtyLabel));

                //add single order to myOrder class
                MyOrder myOrder = new MyOrder();
                myOrder.addMyOrder(ToppingLabel, SizeLabel, Convert.ToInt32(QtyLabel), singleOrderPrice);

                //assign to price object
                price.totalPrice = manager.getTotalPrice();
                price.totalQty = manager.getTotalQty();

                //add order information to manager class
                manager.addMyOrderToList(myOrder);
                manager.AddTotalPriceAndQty(price.totalPrice, price.totalQty);

                ToppingLabel = "none";
                SizeLabel = "none";
                QtyLabel = "none";

                DisplayAlert("Success!!", mes, "OK");

            }
            else
            {

                DisplayAlert("Alert", "Please select at least 1 quantity", "OK");
            }
        }

        void resetButton_Clicked(System.Object sender, System.EventArgs e)
        {
            ToppingLabel = "none";
            SizeLabel = "none";
            QtyLabel = "none";
        }

        async void NavigateToManageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ManagerPage(manager));
        }
    }
}

