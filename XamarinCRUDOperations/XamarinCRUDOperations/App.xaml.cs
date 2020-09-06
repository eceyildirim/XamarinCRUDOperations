using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCRUDOperations.Views;

namespace XamarinCRUDOperations
{
    public partial class App : Application
    {
        public static string DbName { get; set; } = "bookDb.db3";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
