using SQLiteApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppSQlite
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";
        public static LibraryRepository database;
        public static LibraryRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new LibraryRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}