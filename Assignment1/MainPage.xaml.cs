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
       
        Manager manager = new Manager();


        public MainPage()
        {
           
            InitializeComponent();
            toppingList.ItemsSource = manager.toppings;
            sizeList.ItemsSource = manager.sizes;
            BindingContext = this;

         


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
          
        }

        void sizeList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
           SizeLabel = (e.SelectedItem as PizzaSize).name;
            
        }

        void qtyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var btn = (Button)sender;
            QtyLabel = btn.Text;
           
        }
    }
}

