using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTest.Models;

namespace XamarinTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
        }
        /*
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (!(((ListView)sender).SelectedItem is Coffee coffee))
                return;

            await DisplayAlert("Coffee Selected", coffee.Name, "OK");
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            if (!(((MenuItem)sender).BindingContext is Coffee coffee))
                return;

            await DisplayAlert("Coffee Favorited", coffee.Name, "OK");
        }*/
    }
}