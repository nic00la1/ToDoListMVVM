using System.Collections.ObjectModel;
using System.Windows.Input;
using ToDoListMVVM.Models;

namespace ToDoListMVVM.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private string _newTaskDescription;
        public string NewTaskDescription
        {
            get => _newTaskDescription;
            set
            {
                _newTaskDescription = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Models.Task> Tasks { get; set; } = new ObservableCollection<Models.Task>();

        public ICommand AddTaskCommand { get; }

        public MainPageViewModel()
        {
            AddTaskCommand = new Command(AddTask);
        }

        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(NewTaskDescription))
            {
                Tasks.Add(new Models.Task { Description = NewTaskDescription });
                NewTaskDescription = string.Empty;
            }
        }
    }
}
