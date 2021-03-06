﻿using System;
using FindMe.ViewModels;
using Xamarin.Forms;

namespace FindMe.Views
{
    public partial class Options : ContentPage
    {
        public Options()
        {
            Title = "Options";
            InitializeComponent();
            if(Device.OS == TargetPlatform.Windows)
            {
                lVib.IsVisible = false;
                sVib.IsVisible = false;
            }
            BindingContext = new OptionsViewModel();
            nbIcones.SelectedIndexChanged += (s, e) =>
            {
                OptionsViewModel o = new OptionsViewModel();
                o.NbIcones = Int32.Parse(nbIcones.Items[nbIcones.SelectedIndex]);
            };
        }
    }
}
