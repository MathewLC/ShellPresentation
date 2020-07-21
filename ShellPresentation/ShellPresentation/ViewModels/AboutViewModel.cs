using ShellPresentation.Models;
using ShellPresentation.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ShellPresentation.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private uint age;

        public uint Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }

        public AboutViewModel(IDataStore<Item> dataStore):base(dataStore)
        {
            Title = "About";
            OpenWebCommand = new AsyncCommand(OpenWebCommandExecute);
        }

        private async Task OpenWebCommandExecute()
        {
            await  Navigation.GoToAsync("InfoViewModel", new User
            {
                UserName = Name,
                UserAge = Age
            });
        }

        public AsyncCommand OpenWebCommand { get; }
    }
}