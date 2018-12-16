using SQLiteApp;
using System;
using Xamarin.Forms;

namespace AppSQlite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            bookList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Library selectedFriend = (Library)e.SelectedItem;
            LibraryPage libraryPage = new LibraryPage();
            libraryPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(libraryPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateLibrary(object sender, EventArgs e)
        {
            Library library = new Library();
            LibraryPage libraryPage = new LibraryPage();
            libraryPage.BindingContext = library;
            await Navigation.PushAsync(libraryPage);
        }
    }
}