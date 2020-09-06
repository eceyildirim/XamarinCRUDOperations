using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCRUDOperations.Helper;
using XamarinCRUDOperations.Models;

namespace XamarinCRUDOperations.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        static List<Book> books;
        SQLiteManager sQLiteManager;
        public ListPage()
        {
            InitializeComponent();
            books = new List<Book>();
            sQLiteManager = new SQLiteManager();
            RefreshData();
        }

        private void Refresh_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            books = sQLiteManager.GetBooks().ToList();

            listViewBooks.BindingContext = books;
        }

        private void Insert_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }
    }
}