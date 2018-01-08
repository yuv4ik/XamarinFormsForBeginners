using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoList
{
    public partial class AddANewToDoItemPage : ContentPage
    {
        public AddANewToDoItemPage()
        {
            InitializeComponent();
        }

        async void HandleAddNewToDoItemClick(object sender, System.EventArgs e)
        {
            var todoItem = new ToDoItem
            {
                Description = eDescription.Text,
                CreatedAt = DateTimeOffset.Now
            };

            (Application.Current as App).Items.Add(todoItem);
            await CloseTheCurrentModalPage();
        }

        async void HandleCancelClick(object sender, System.EventArgs e) =>
            await CloseTheCurrentModalPage();

        async Task CloseTheCurrentModalPage() => await Navigation.PopModalAsync();
    }
}
