using AudioToolbox;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Telephone
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClavierPage : ContentPage
	{
		public ClavierPage ()
		{
			InitializeComponent ();

            text.Text = "";
		}
        public void addNum(object sender, EventArgs args)
        {
            if (sender is Button)
            {
                if (text.Text.Length < 10)
                {
                    text.Text += (sender as Button).Text.Trim();
                    SystemSound.Vibrate.PlaySystemSound();
                }
            }
        }
        public void dellNum(object sender, EventArgs args)
        {
            if (sender is Button) 
            {
                if(text.Text.Length > 0)
                {
                    text.Text = text.Text.Remove(text.Text.Length - 1);
                }
                SystemSound.Vibrate.PlayAlertSound();
            }
        }
        public void callNum(object sender, EventArgs args)
        {
            if (sender is Button)
            {
                if (text.Text.Length.Equals(10))
                {
                    Device.OpenUri(new Uri("tel:" + text.Text));
                }
            }
        }
    }
}