using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using XamarinCRUDOperations.Droid.ConnectionHelper;
using XamarinCRUDOperations.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(GetDroidConnection))]
namespace XamarinCRUDOperations.Droid.ConnectionHelper
{
    public class GetDroidConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, App.DbName);

            var connection = new SQLite.SQLiteConnection(path);

            return connection;
        }
    }
}