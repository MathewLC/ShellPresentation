﻿using ShellPresentation.Models;
using ShellPresentation.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellPresentation.ViewModels
{
    public class InfoViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public uint Age { get; set; }

        public Command FinalCommand { get; }
        public InfoViewModel(IDataStore<Item> dataStore) : base(dataStore) 
        {
            FinalCommand = new AsyncCommand(FinalCommandExecute);
        }

        async Task FinalCommandExecute()
        {
            await Navigation.GoToAsync(nameof(FinalViewModel));
        }

        public override Task InitAsync(object args)
        {
            var user = (User)args;
            Name = user?.UserName;
            Age = user?.UserAge ?? 0;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Age));

            return base.InitAsync(args);
        }
    }
}
