using System.Collections.Generic;
using System.Linq;
using AppSQlite;
using SQLite;
using Xamarin.Forms;

namespace SQLiteApp
{
    public class LibraryRepository
    {
        SQLiteConnection database;
        public LibraryRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Library>();
        }
        public IEnumerable<Library> GetItems()
        {
            return (from i in database.Table<Library>() select i).ToList();

        }
        public Library GetItem(int id)
        {
            return database.Get<Library>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Library>(id);
        }
        public int SaveItem(Library item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}