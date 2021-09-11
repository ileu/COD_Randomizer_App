using COD_Randomizer_App.Services;
using Xamarin.Forms;

namespace COD_Randomizer_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            LocalDataService.LoadMotherLoadout();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
