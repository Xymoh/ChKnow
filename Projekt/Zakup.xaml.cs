using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Zakup : ContentPage
	{
		public Zakup ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var url = "https://cdp.pl/wiedzmin-3-dziki-gon-pc.html";
            Device.OpenUri(new Uri(url));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var url = "https://eu.shop.battle.net/en-gb/family/world-of-warcraft";
            Device.OpenUri(new Uri(url));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var url = "https://www.origin.com/pol/pl-pl/store/apex/apex";
            Device.OpenUri(new Uri(url));
        }
    }
}