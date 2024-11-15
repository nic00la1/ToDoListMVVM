public class Task : BindableObject
{
    private string _description;
    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            OnPropertyChanged();
        }
    }

    private bool _isCompleted;
    public bool IsCompleted
    {
        get => _isCompleted;
        set
        {
            _isCompleted = value;
            OnPropertyChanged();
        }
    }

    public bool IsEnabled { get; set; }
    public DateTime DateAdded { get; set; }

    private DateTime? _dateCompleted;
    public DateTime? DateCompleted
    {
        get => _dateCompleted;
        set
        {
            _dateCompleted = value;
            OnPropertyChanged();
        }
    }
}