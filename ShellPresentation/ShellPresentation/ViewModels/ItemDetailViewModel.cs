using System;

using ShellPresentation.Models;
using ShellPresentation.Services;

namespace ShellPresentation.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(IDataStore<Item> dataStore, Item item = null) : base(dataStore)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
