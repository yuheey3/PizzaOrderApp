//June7,2021
//Yuki Waka
//141082180
using System;
using Assignment1.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment1
{
    public partial class App : Application
    {
        Manager manager;

        public App()
        {
            InitializeComponent();
            manager = new Manager();
            MainPage = new NavigationPage(new MainPage(manager));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
