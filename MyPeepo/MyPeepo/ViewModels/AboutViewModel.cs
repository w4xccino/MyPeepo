using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyPeepo.ViewModels
{
    public class AboutViewModel : ContentPage
    {
        public AboutViewModel()
        {
            Title = "Inicio";
            OpenWebCommand = new Command(async () => await Navigation.PushAsync(new Views.ItemsPage()));
        }

        //public async void xd(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Views.AboutPage());
        //}

        public ICommand OpenWebCommand { get; }
    }
}