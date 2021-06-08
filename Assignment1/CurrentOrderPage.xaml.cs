//June7,2021
//Yuki Waka
//141082180
using System;
using System.Collections.Generic;
using Assignment1.Model;
using Xamarin.Forms;

namespace Assignment1
{
    public partial class CurrentOrderPage : ContentPage
    {
        Manager manager;

        private string totalPrice = "none";
        private string totalQty = "none";

        public CurrentOrderPage(Manager m)
        {
            InitializeComponent();
            manager = m;
            myOrderList.ItemsSource = manager.myOrders;

            totalPrice = (manager.prices.totalPrice).ToString();
            totalQty = (manager.prices.totalQty).ToString();
            BindingContext = this;
        }

        public string TotalPrice
        {
            get { return totalPrice; }
            set
            {
                totalPrice = value;
                OnPropertyChanged(nameof(TotalPrice)); // Notify that there was a change on this property

            }
        }
        public string TotalQty
        {
            get { return totalQty; }
            set
            {
                totalQty = value;
                OnPropertyChanged(nameof(TotalQty)); // Notify that there was a change on this property

            }
        }
        void myOrderList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

        }

        async void PlaceOrderButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //add history order 
            var date = DateTime.Now.ToString("MMMM d, yyyy, h:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            HistoryOrder historyOrder = new HistoryOrder(Convert.ToInt32(manager.getTotalQty()), manager.getTotalPrice(), date);

            manager.addHistoryOrder(historyOrder);

            manager.initializeValue();

            _ = DisplayAlert("Success!!", "Thank you for your ordering!", "OK");

            await Navigation.PushAsync(new ManagerPage(manager));
        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var item = sender as MenuItem;

            var myOrder = (item.CommandParameter as MyOrder);

            //get quantity 
            var qty = myOrder.qty;
            var price = myOrder.price;

            //change total quantity and price in the Price object
            manager.changeTotalQty(qty);
            manager.changeTotalPrice(price);

            //change label value
            TotalPrice = (manager.prices.totalPrice).ToString();
            TotalQty = (manager.prices.totalQty).ToString();

            manager.deletemyOrder(myOrder);

        }
    }
}
