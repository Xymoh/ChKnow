using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Projekt
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<string> universums;
        List<TTF> things;
        TTF selectedThing;
        string selectedUniversum;

        public List<string> UniversumList
        {
            get { return universums; }
            set
            {
                universums = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ThingList"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UniversumList"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedUniversum"));
            }
        }

        public List<TTF> ThingList
        {
            get { return things; }
            set
            {
                things = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ThingList"));
            }
        }

        public TTF SelectedThing
        {
            get { return selectedThing; }
            set
            {
                selectedThing = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedThing"));
            }
        }

        public string SelectedUniversum
        {
            get { return selectedUniversum; }
            set
            {
                selectedUniversum = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedUniversum"));
            }
        }
    }
}
