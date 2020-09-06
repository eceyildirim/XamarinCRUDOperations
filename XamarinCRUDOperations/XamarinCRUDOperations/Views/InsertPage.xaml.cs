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
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private void ButtonInsert_Clicked(object sender, EventArgs e)
        {
            SQLiteManager sQLiteManager = new SQLiteManager();
            Book book = new Book();

            book.Name = entryCellName.Text;
            book.Author = entryCellAuthor.Text;
            book.Publisher = entryCellPublisher.Text;

            int isInserted = sQLiteManager.Insert(book);

            if(isInserted > 0)
            {
                DisplayAlert("Kayıt Başarılı", book.Name, "OK");
            }
            else
            {
                DisplayAlert("Kayıt Başarısız", book.Name, "OK");
            }
        }
    }
}