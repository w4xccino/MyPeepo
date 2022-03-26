using MyPeepo.ViewModels;
using MyPeepo.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyPeepo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage)); // pagina para ver detalles de los items
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage)); //Nueva pagina para agregar item
        }

    }
}
