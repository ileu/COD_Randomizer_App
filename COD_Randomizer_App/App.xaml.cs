using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COD_Randomizer_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MediaPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
