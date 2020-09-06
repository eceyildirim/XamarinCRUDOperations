using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinCRUDOperations.Models;

namespace XamarinCRUDOperations.Helper
{
    public class SQLiteManager
    {
        SQLiteConnection _sqliteConnection;

        public SQLiteManager()
        {
            _sqliteConnection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            _sqliteConnection.CreateTable<Book>();
        }

        #region CRUD
        public int Insert(Book b)
        {
            return _sqliteConnection.Insert(b);
        }

        public List<Book> GetBooks()
        {
            return _sqliteConnection.Table<Book>().ToList();
        }

        public void Dispose()
        {
            _sqliteConnection.Close();
        }
        #endregion
    }
}
