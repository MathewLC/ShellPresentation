using System.ComponentModel;
using Xamarin.Forms;

using ShellPresentation.Models;
using ShellPresentation.ViewModels;
using ShellPresentation.Services;

namespace ShellPresentation.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage()
        {
            InitializeComponent();

            //var item = new Item
            //{
            //    Text = "Item 1",
            //    Description = "This is an item description."
            //};

            //var dataStore = (IDataStore<Item>)Startup.ServiceProvider.GetService(typeof(IDataStore<Item>));
            //viewModel = new ItemDetailViewModel(dataStore,item);
            //BindingContext = viewModel;

        }
    }
}