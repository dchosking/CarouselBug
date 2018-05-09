using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Prism.Unity;
using Prism;
using Prism.Ioc;
using ExampleCarousel.Views;
using ExampleCarousel.ViewModels;
using Xamarin.Forms;

namespace ExampleCarousel
{
    public partial class App : PrismApplication
    {
        // Use a service for providing this information
        public static bool IsUserLoggedIn { get; set; }

        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
            LiveReload.Init();
            InitializeComponent();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<MenuPage>("Index");
            containerRegistry.RegisterForNavigation<EditProfilePage, UserProfileViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("/Index/Navigation/HomePage");
        }
    }
}
