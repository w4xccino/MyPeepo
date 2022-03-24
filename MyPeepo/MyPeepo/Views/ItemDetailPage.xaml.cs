using MyPeepo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyPeepo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}