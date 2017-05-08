using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.Views
{
    public class MyContentPage2 : ContentPage
    {
        public MyContentPage2()
        {
            BackgroundColor = Color.Black;

            Label lblPAge = new Label();
            lblPAge.Text = "Merhaba Erkan!";
            lblPAge.FontSize = 30;
            lblPAge.HorizontalOptions = LayoutOptions.Center;
            lblPAge.VerticalOptions = LayoutOptions.Center;
            lblPAge.TextColor = Color.White;

            Content = lblPAge;
        }
    }
}
