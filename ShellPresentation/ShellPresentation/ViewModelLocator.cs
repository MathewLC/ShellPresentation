using ShellPresentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellPresentation
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => (MainViewModel)Startup.ServiceProvider.GetService(typeof(MainViewModel));
        public AboutViewModel AboutViewModel => (AboutViewModel)Startup.ServiceProvider.GetService(typeof(AboutViewModel));
    }
}
