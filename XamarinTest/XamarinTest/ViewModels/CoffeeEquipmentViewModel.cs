using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Windows.Input;

namespace XamarinTest.ViewModels
{
    class CoffeeEquipmentViewModel : ObservableObject
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
