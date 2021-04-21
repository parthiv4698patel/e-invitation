using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SQLite;
using Xamarin.Forms;
using einvitation.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace einvitation.Droid
{
    class SQLite_Android : ISQLite
    {
        SQLiteConnection con;
        public SQLiteConnection GetConnectionWithCreateDatabase()
        {
            string fileName = "sampleDatabase.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentPath, fileName);
            con = new SQLiteConnection(path);
            con.CreateTable<Event>();
            return con;
        }
        public bool ButtonClicked3(Event evt)
        {
            bool res = false;
            try
            {
                con.Insert(evt);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }// button click close

        public List<Event> GetEvents()
        {
            string sql = "SELECT * FROM Event";
            List<Event> events = con.Query<Event>(sql);
            return events;
        }
    }
}