using App2.TabbedSayfalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.Views
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new Layouts.RelativeOrnek());
            Children.Add(new Layouts.GridOrnek());
            Children.Add(new Layouts.AbsoluteOrnek());
        }
    }
}
