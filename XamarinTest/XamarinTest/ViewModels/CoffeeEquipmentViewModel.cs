using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinTest.ViewModels
{
    class CoffeeEquipmentViewModel : BindableObject
    {
        public CoffeeEquipmentViewModel()
        {
            IncrementCount = new Command(OnIncrease);
        }
        public ICommand IncrementCount { get; }

        int count = 0;
        string countDisplay = "Click Me!";
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                {
                    return;
                }
                countDisplay = value;
                OnPropertyChanged();
            }
        }
        void OnIncrease()
        {
            count++;
            CountDisplay = $"Clicked {count} times";
        }
    }
}
