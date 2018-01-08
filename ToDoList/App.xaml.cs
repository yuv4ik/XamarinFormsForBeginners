using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ToDoList
{
    public partial class App : Application
    {
        /*
         * 1. Show a list of to-do items
         * 2. Create a new to-do item
         */

        public ObservableCollection<ToDoItem> Items { get; } = new ObservableCollection<ToDoItem>();

        public App()
        {
            InitializeComponent();

            MainPage = new ToDoListPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
