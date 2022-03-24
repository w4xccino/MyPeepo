using MyPeepo.Services;
using MyPeepo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPeepo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
