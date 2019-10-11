using System;
using Xamarin.Forms;

namespace TodoAppClient
{
    public partial class MainPage : ContentPage
    {
        private readonly TodoService ts;

        public MainPage()
        {
            InitializeComponent();
            ts = new TodoService();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // If I populate listview with data from web api
            // then e.SelectedItem becomes always null.
            // This only happens on UWP. 
            // It works just fine on Android. I haven't tested on iOS.
            listViewTodo.ItemsSource = await ts.GetTodoItemsAsync();
            
            

            // But if I populate listview with hard-coded data, 
            // there is no problem on UWP (and Android).
            //listViewTodo.ItemsSource = new TodoItem[] 
            //{
            //    new TodoItem { Text = "Accompanying ...", Complete = true },
            //    new TodoItem { Text = "Bathing ...", Complete = false }
            //};
        }


        private async void ListViewTodo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // ti becomes always null on UWP if listview is populated with web api data
            TodoItem ti = e.SelectedItem as TodoItem;

            if (ti != null)
                await Navigation.PushAsync(new UpdatePage(ti));
        }
    }
}
