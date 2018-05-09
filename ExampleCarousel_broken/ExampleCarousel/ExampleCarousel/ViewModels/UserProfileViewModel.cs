using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExampleCarousel.ViewModels
{
    public class UserProfileViewModel : INavigationAware, INotifyPropertyChanged
    {
        private readonly INavigationService _navigationService;

        public UserProfileViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));

            _Fullname = "Darryn Hosking";
            _Email = "DarrynHosking@sample.co.za";
            _Gender = "Male";
            _ProfilePicture = "https://www.puriindahmall.co.id/assets/img/default.png";
            _Password = "placeholder";
            _EnableNotifications = true;
            _Birthday = DateTime.UtcNow.AddYears(-30);
        }

        private string _Fullname;
        private string _Email;
        private DateTime _Birthday;
        private string _Gender;
        private bool _EnableNotifications;
        private string _ProfilePicture;
        private string _Password;

        public string Password
        {
            get => _Password;
            set
            {
                if (value == _Password) return;
                _Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ProfilePicture
        {
            get => _ProfilePicture;
            set
            {
                if (value == _ProfilePicture) return;
                _ProfilePicture = value;
                OnPropertyChanged(nameof(ProfilePicture));
            }
        }
        public string Fullname
        {
            get => _Fullname;
            set
            {
                if (value == _Fullname) return;
                _Fullname = value;
                OnPropertyChanged(nameof(Fullname));
            }
        }
        public string Email
        {
            get => _Email;
            set
            {
                if (value == _Email) return;
                _Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public DateTime Birthday
        {
            get => _Birthday;
            set
            {
                if (value == _Birthday) return;
                _Birthday = value;
                OnPropertyChanged(nameof(Birthday));
            }
        }
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                if (_Gender != value)
                {
                    _Gender = value;
                    OnPropertyChanged(nameof(Gender));
                }
            }
        }
        public bool EnableNotifications
        {
            get => _EnableNotifications;
            set
            {
                if (value == _EnableNotifications) return;
                _EnableNotifications = value;
                OnPropertyChanged(nameof(EnableNotifications));
            }
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
