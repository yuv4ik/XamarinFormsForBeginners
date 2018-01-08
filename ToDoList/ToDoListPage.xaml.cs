using Xamarin.Forms;

namespace ToDoList
{
    public partial class ToDoListPage : ContentPage
    {

        public ToDoListPage()
        {
            InitializeComponent();
            lvToDoItems.ItemsSource = (Application.Current as App).Items;
        }

        async void Handle_Clicked(object sender, System.EventArgs e) =>
            await Navigation.PushModalAsync(new AddANewToDoItemPage());
    }
}
