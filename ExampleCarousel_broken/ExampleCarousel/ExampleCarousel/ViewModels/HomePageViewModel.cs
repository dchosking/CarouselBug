using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Prism.Navigation;
using Xamarin.Forms;
using FFImageLoading.Forms;
using System.Diagnostics;
using ImageCircle.Forms.Plugin.Abstractions;

namespace ExampleCarousel.ViewModels
{
    public class HomePageViewModel : INavigationAware, INotifyPropertyChanged
    {
        private readonly INavigationService _navigationService;

        ObservableCollection<View> _myItemsSource;

        public event PropertyChangedEventHandler PropertyChanged;

        public Command MyCommand { protected set; get; }
        public ObservableCollection<View> MyItemsSource
        {
            set
            {
                _myItemsSource = value;
                OnPropertyChanged("MyItemsSource");
            }
            get
            {
                return _myItemsSource;
            }
        }

        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));


            MyItemsSource = new ObservableCollection<View>()
            {
                new CachedImage() { Source = "http://via.placeholder.com/250/f44191/000000", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "http://via.placeholder.com/250/41f459/000000", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "http://via.placeholder.com/250/41eef4/000000", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
            };


            MyCommand = new Command(() =>
            {
                Debug.WriteLine("Position selected.");
            });
        }



        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}
