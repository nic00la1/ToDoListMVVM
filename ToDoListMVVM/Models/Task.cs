namespace ToDoListMVVM.Models
{
    public class Task : BindableObject
    {
        private bool _isCompleted;
        public string Description { get; set; }
        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                _isCompleted = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsEnabled));
            }
        }

        public bool IsEnabled => !IsCompleted;
    }
}