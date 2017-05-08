using App2.MasterSayfalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.Views
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Padding = new Thickness(0, Device.OS == TargetPlatform.iOS ? 20 : 30, 0, 0);

            Master = new MyMenu();
            Detail = new MyTabbedPage();
        }
    }
}
