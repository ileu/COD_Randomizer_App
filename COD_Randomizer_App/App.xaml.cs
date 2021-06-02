﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using COD_Randomizer_App.Views;

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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
