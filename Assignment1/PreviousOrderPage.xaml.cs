//June7,2021
//Yuki Waka
//141082180
using System;
using System.Collections.Generic;
using Assignment1.Model;
using Xamarin.Forms;

namespace Assignment1
{
    public partial class PreviousOrderPage : ContentPage
    {
        Manager manager;

        public PreviousOrderPage(Manager m)
        {
            manager = m;
            InitializeComponent();

            historyOrderList.ItemsSource = manager.historyOrders;

            BindingContext = this;
        }

        void historyOrderList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

        }

    }
}

