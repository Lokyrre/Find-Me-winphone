using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FindMe.Views.Templates
{
    public class LeaderboardItemTemplate : ViewCell
    {
        public LeaderboardItemTemplate()
        {
            StackLayout sLayout = new StackLayout { Orientation = StackOrientation.Horizontal };

            Label username = new Label();
            Label score = new Label();
            Label Location = new Label();

           // username.Text = SetBinding(Label.TextProperty, "username");
        }
    }
}
