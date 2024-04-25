using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinTest.Models;

namespace XamarinTest.ViewModels
{
    class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Coffee> Coffee { get; set; }
        public ObservableRangeCollection<Grouping<string, Coffee>> CoffeeGroups { get; set; } // <key, value>
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand<Coffee> FavoriteCommand { get; }
        public CoffeeEquipmentViewModel()
        {
            Title = "Coffie Equipment";

            Coffee = new ObservableRangeCollection<Coffee>();
            CoffeeGroups = new ObservableRangeCollection<Grouping<string, Coffee>>();

            var image = "https://images.prismic.io/yesplz/b6412878-3c69-4366-9ab7-cddbd551e4fa_bow_bag-min.png?auto=compress,format";

            /*IncrementCount = new Command(OnIncrease);
            IncrementCount = new AsyncCommand(CallServer);//ODC 6-7*/
            Coffee.Add(new Coffee { Roaster = "Yes plz", Name = "Bag", Image = image });
            Coffee.Add(new Coffee { Roaster = "Yes plz", Name = "Potent", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue", Name = "Kenya", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue", Name = "Kenaya", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue", Name = "Kenaya", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue", Name = "Kenaya", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue", Name = "Kenaya", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue", Name = "Kenaya", Image = image });

            CoffeeGroups.Add(new Grouping<string, Coffee>("Blue", new[] { Coffee[2] }));
            CoffeeGroups.Add(new Grouping<string, Coffee>("Yes plz", Coffee.Take(2)));

            RefreshCommand = new AsyncCommand(Refresh);
            FavoriteCommand = new AsyncCommand<Coffee>(Favorite);
        }
        async Task Favorite(Coffee coffee)
        {
            if (coffee == null)
                return;
            await Application.Current.MainPage.DisplayAlert("Favorite", coffee.Name, "Ok");
        }
        Coffee selectedCoffee;
        public Coffee SelectedCoffee
        {
            get => selectedCoffee;
            set
            {
                if(value != null)
                {
                    Application.Current.MainPage.DisplayAlert("Selected", value.Name, "Ok");
                    value = null;
                }
                selectedCoffee = value;
                OnPropertyChanged();
            }
        }
        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }

        /*public ICommand CallServerCommand { get; }
        async Task CallServer()
        {
            var items = new List<string> { "1", "2", "3" };
            Coffee.AddRange(items);
        }
        public ICommand IncrementCount { get; }

        int count = 0;
        string countDisplay = "Click Me!";
        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }
        void OnIncrease()
        {
            count++;
            CountDisplay = $"Clicked {count} times";
        }//ODC 6-7*/
    }
}
