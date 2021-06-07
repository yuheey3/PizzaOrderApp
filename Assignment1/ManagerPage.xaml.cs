using System;
using System.Collections.Generic;
using Assignment1.Model;
using Xamarin.Forms;

namespace Assignment1
{
    public partial class ManagerPage : ContentPage
    {
        Manager manager;

        public ManagerPage(Manager m)
        {
            InitializeComponent();
            manager = m;
            //sizeList.ItemsSource = manager.sizes;
            //BindingContext = this;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CurrentOrderPage(manager));
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
        }
    }
}
