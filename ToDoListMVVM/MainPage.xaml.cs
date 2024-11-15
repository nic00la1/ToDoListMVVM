using ToDoListMVVM.ViewModels;

namespace ToDoListMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTaskCompletedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.BindingContext is Task task)
            {
                if (BindingContext is MainPageViewModel viewModel)
                {
                    viewModel.OnTaskCompletedChanged(task);
                }
            }
        }
    }
}