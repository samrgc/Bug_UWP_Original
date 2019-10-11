using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoAppClient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdatePage : ContentPage
    {
        private readonly TodoService ts;
        private readonly string id;

        public UpdatePage(TodoItem ti)
        {
            InitializeComponent();
            ts = new TodoService();
            entryText.Text = ti.Text;
            id = ti.Id;
        }

        private async void ToolbarItemSave_Clicked(object sender, EventArgs e)
        {
            TodoItem ti = new TodoItem
            {
                Text = entryText.Text,
                Id = id
            };

            await ts.UpdateTodoItemAsync(ti);
            await Navigation.PopAsync();
        }
    }
}