﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new Nota();
            MainPage = new NavigationPage(new login());
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
