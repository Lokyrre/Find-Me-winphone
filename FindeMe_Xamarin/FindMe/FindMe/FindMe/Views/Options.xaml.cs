using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            BindingContext = new OptionsViewModel();
            nbIcones.SelectedIndexChanged += (s, e) =>
            {
                OptionsViewModel o = new OptionsViewModel();
                o.NbIcones = Int32.Parse(nbIcones.Items[nbIcones.SelectedIndex]);
            };
        }
    }
}
