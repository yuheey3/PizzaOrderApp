﻿using System;
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

        // public string totalPriceQty { get; } = "MY TEXT";

        public CurrentOrderPage(Manager m)
        {
            InitializeComponent();
            manager = m;
            myOrderList.ItemsSource = manager.myOrders;
           // public string totalPriceQty { get; } = "MY TEXT";
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

        async void NavigateToManageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            _ = DisplayAlert("Success!!", "Thank you for your ordering!", "OK");
            await Navigation.PushAsync(new ManagerPage(manager));
        }
    }
}
