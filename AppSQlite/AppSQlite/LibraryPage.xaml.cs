using SQLiteApp;
using System;
using Xamarin.Forms;

namespace AppSQlite
{
    public partial class LibraryPage : ContentPage
    {
        public LibraryPage()
        {
            InitializeComponent();
        }

        private void SaveLibrary(object sender, EventArgs e)
        {
            var library = (Library)BindingContext;
            if (!String.IsNullOrEmpty(library.Author))
            {
                App.Database.SaveItem(library);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteLibrary(object sender, EventArgs e)
        {
            var library = (Library)BindingContext;
            App.Database.DeleteItem(library.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}