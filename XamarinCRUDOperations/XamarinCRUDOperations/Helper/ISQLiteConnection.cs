using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCRUDOperations.Helper
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}
