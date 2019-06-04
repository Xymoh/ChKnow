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
    public partial class Tapety : ContentPage
    {
        public Tapety()
        {
            InitializeComponent();
        }

        private void Geralt_Clicked(object sender, EventArgs e)
        {
            var url = "https://drive.google.com/uc?export=download&id=1h3_ynFBlxV-5Suz7jqixOnIdd3PE1hff";
            Device.OpenUri(new Uri(url));
        }

        private void Yennefer_Clicked(object sender, EventArgs e)
        {
            var url = "https://drive.google.com/uc?export=download&id=1ewtbYOoQ26JJCpIo-wSmI4zy73eZCnfM";
            Device.OpenUri(new Uri(url));
        }

        private void Thrall_Clicked(object sender, EventArgs e)
        {
            var url = "https://drive.google.com/uc?export=download&id=1038T1jt_k52WhRB-bHMIyrSfGnaZ0Ca6";
            Device.OpenUri(new Uri(url));
        }

        private void Arthas_Clicked(object sender, EventArgs e)
        {
            var url = "https://drive.google.com/uc?export=download&id=1LRH0NM1OpoOPN-289e7ZxSQOpGRPQsay";
            Device.OpenUri(new Uri(url));
        }

        private void Bloodhound_Clicked(object sender, EventArgs e)
        {
            var url = "https://drive.google.com/uc?export=download&id=1ZrO-2Cy1CtLlNIE8YQUNhkVH305oMNHq";
            Device.OpenUri(new Uri(url));
        }

        private void Mirage_Clicked(object sender, EventArgs e)
        {
            var url = "https://drive.google.com/uc?export=download&id=1qZC8TdQUkeEZ0JZUbP4jhDD-oTFXjROU";
            Device.OpenUri(new Uri(url));
        }
    }
}