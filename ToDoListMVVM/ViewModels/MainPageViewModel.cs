using System.Collections.ObjectModel;
using System.Windows.Input;
using ToDoListMVVM;

namespace ToDoListMVVM.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private string _newTaskDescription = string.Empty;
        public string NewTaskDescription
        {
            get => _newTaskDescription;
            set
            {
                _newTaskDescription = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Task> Tasks { get; set; } = new ObservableCollection<Task>();

        public ICommand AddTaskCommand { get; }
        public ICommand RemoveTaskCommand { get; }

        public MainPageViewModel()
        {
            AddTaskCommand = new Command(AddTask);
            RemoveTaskCommand = new Command<Task>(RemoveTask);
        }

        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(NewTaskDescription))
            {
                Tasks.Add(new Task
                {
                    Description = NewTaskDescription,
                    DateAdded = DateTime.Now,
                    IsEnabled = true
                });
                NewTaskDescription = string.Empty;
            }
        }

        private void RemoveTask(Task task)
        {
            if (Tasks.Contains(task))
            {
                Tasks.Remove(task);
            }
        }

        public void OnTaskCompletedChanged(Task task)
        {
            if (task.IsCompleted)
            {
                task.DateCompleted = DateTime.Now;
            }
            else
            {
                task.DateCompleted = null;
            }
        }
    }
}