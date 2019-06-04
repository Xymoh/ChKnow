using Projekt.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projekt
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
            NavigationPage.SetHasNavigationBar(this, false);

            menuList = new List<MasterPageItem>();

            menuList.Add(new MasterPageItem()
            {
                Title = "Wiki",
                Icon = "book.png",
                TargetType = typeof(HomePage)
            });

            menuList.Add(new MasterPageItem()
            {
                Title = "Tapety",
                Icon = "wallpaper.png",
                TargetType = typeof(Tapety)
            });

            menuList.Add(new MasterPageItem()
            {
                Title = "Zakup",
                Icon = "cart.png",
                TargetType = typeof(Zakup)
            });

            menuList.Add(new MasterPageItem()
            {
                Title = "O mnie",
                Icon = "about.png",
                TargetType = typeof(Omnie)
            });

            navigationDrawerList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
