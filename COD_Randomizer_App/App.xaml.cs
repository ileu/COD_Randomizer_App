using System;
using COD_Randomizer_App.Services;
using COD_Randomizer_App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COD_Randomizer_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
