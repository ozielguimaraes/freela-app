using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Prototipo.Models;
using Prototipo.Vms;

namespace Prototipo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailVm Vm;

        public ItemDetailPage(ItemDetailVm Vm)
        {
            InitializeComponent();

            BindingContext = this.Vm = Vm;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            Vm = new ItemDetailVm(item);
            BindingContext = Vm;
        }
    }
}