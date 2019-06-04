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
    public partial class HomePage : ContentPage
    {
        ViewModel showResult;

        List<string> universums = new List<string>
        {   "Wiedźmin",
            "World of Warcraft",
            "Apex Legends"
        };

        List<TTF> things = new List<TTF>
        {
            new TTF {Universum="Wiedźmin", Thing="Geralt"},
            new TTF {Universum="Wiedźmin", Thing="Ciri"},
            new TTF {Universum="Wiedźmin", Thing="Yennefer"},
            new TTF {Universum="Wiedźmin", Thing="Triss Merigold"},
            new TTF {Universum="Wiedźmin", Thing="Emhyr var Emreis"},
            new TTF {Universum="World of Warcraft", Thing="Thrall"},
            new TTF {Universum="World of Warcraft", Thing="Jaina Proudmoore"},
            new TTF {Universum="World of Warcraft", Thing="Arthas"},
            new TTF {Universum="World of Warcraft", Thing="Durotan"},
            new TTF {Universum="World of Warcraft", Thing="Garrosh"},
            new TTF {Universum="Apex Legends", Thing="Wraith"},
            new TTF {Universum="Apex Legends", Thing="Bangalore"},
            new TTF {Universum="Apex Legends", Thing="Bloodhound"},
            new TTF {Universum="Apex Legends", Thing="Mirage"},
            new TTF {Universum="Apex Legends", Thing="Gibraltar"}
        };

        public HomePage()
        {
            InitializeComponent();

            this.BindingContext = showResult = new ViewModel
            {
                UniversumList = universums,
                ThingList = things.Where(thing => thing.Universum == universums[0]).ToList(),
                SelectedUniversum = universums[0],
                SelectedThing = things[0]
            };
        }

        void ThingPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null && !string.IsNullOrWhiteSpace(picker.SelectedItem.ToString()))
            {
                showResult.SelectedThing = things.Where(thing => thing == picker.SelectedItem).ToList()[0];
            }
        }

        private void UniversumPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;
            if (picker.SelectedItem != null)
            {
                showResult.SelectedUniversum = picker.SelectedItem.ToString();
                showResult.ThingList = things.Where(thing => thing.Universum == showResult.SelectedUniversum).ToList();
                showResult.SelectedThing = showResult.ThingList[0];
            }

            if (universumPicker.SelectedIndex == 0)
                BackgroundImage = "backgroundWitcher.jpg";
            else if (universumPicker.SelectedIndex == 1)
                BackgroundImage = "backgroundWow.jpg";
            else if (universumPicker.SelectedIndex == 2)
                BackgroundImage = "backgroundApex.jpg";
        }

        private void Confirm_Clicked(object sender, EventArgs e)
        {
            ///////////////
            // Wiedźmin //
            //////////////
            if (universumPicker.SelectedIndex == 0)
            {
                if (objectPicker.SelectedIndex == 0)
                    Device.OpenUri(new Uri("https://wiedzmin.fandom.com/wiki/Geralt"));  // Geralt //
                else if (objectPicker.SelectedIndex == 1)
                    Device.OpenUri(new Uri("https://wiedzmin.fandom.com/wiki/Ciri"));  // Ciri //
                else if (objectPicker.SelectedIndex == 2)
                    Device.OpenUri(new Uri("https://wiedzmin.fandom.com/wiki/Yennefer"));  // Yennefer //
                else if (objectPicker.SelectedIndex == 3)
                    Device.OpenUri(new Uri("https://wiedzmin.fandom.com/wiki/Triss_Merigold"));  // Triss //
                else if (objectPicker.SelectedIndex == 4)
                    Device.OpenUri(new Uri("https://wiedzmin.fandom.com/wiki/Emhyr_var_Emreis"));  // Emhyr var Emreis //
            }
            ///////////////////////
            // World of Warcraft //
            ///////////////////////
            else if (universumPicker.SelectedIndex == 1)
            {
                if (objectPicker.SelectedIndex == 0)
                    Device.OpenUri(new Uri("https://wowwiki.fandom.com/pl/wiki/Thrall"));  // Thrall //
                else if (objectPicker.SelectedIndex == 1)
                    Device.OpenUri(new Uri("https://wowwiki.fandom.com/pl/wiki/Jaina_Proudmoore"));  // Jaina Proudmoore //
                else if (objectPicker.SelectedIndex == 2)
                    Device.OpenUri(new Uri("https://wowwiki.fandom.com/pl/wiki/Arthas_Menethil"));  // Arthas Menethil //
                else if (objectPicker.SelectedIndex == 3)
                    Device.OpenUri(new Uri("https://wowwiki.fandom.com/pl/wiki/Durotan"));  // Durotan //
                else if (objectPicker.SelectedIndex == 4)
                    Device.OpenUri(new Uri("https://wowwiki.fandom.com/pl/wiki/Garrosh_Hellscream"));  // Garrosh Hellscream //
            }
            //////////////////
            // Apex Legends //
            //////////////////
            else if (universumPicker.SelectedIndex == 2)
            {
                if (objectPicker.SelectedIndex == 0)
                    Device.OpenUri(new Uri("https://apex-legends.fandom.com/pl/wiki/Wraith"));  // Wraith //
                else if (objectPicker.SelectedIndex == 1)
                    Device.OpenUri(new Uri("https://apex-legends.fandom.com/pl/wiki/Bangalore"));  // Bangalore //
                else if (objectPicker.SelectedIndex == 2)
                    Device.OpenUri(new Uri("https://apex-legends.fandom.com/pl/wiki/Bloodhound"));  // Bloodhound //
                else if (objectPicker.SelectedIndex == 3)
                    Device.OpenUri(new Uri("https://apex-legends.fandom.com/pl/wiki/Mirage"));  // Mirage //
                else if (objectPicker.SelectedIndex == 4)
                    Device.OpenUri(new Uri("https://apex-legends.fandom.com/pl/wiki/Gibraltar"));  // Gibraltar //
            }
        }
    }
}