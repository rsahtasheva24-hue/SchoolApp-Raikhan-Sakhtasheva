using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SchoolApp.ViewModels;

public class StudentsViewModel : INotifyPropertyChanged
{
    public ObservableCollection<string> Students { get; set; }

    private string _newStudentName = string.Empty;

    public string NewStudentName
    {
        get => _newStudentName;
        set
        {
            if (_newStudentName != value)
            {
                _newStudentName = value;
                OnPropertyChanged();
            }
        }
    }

    public StudentsViewModel()
    {
        Students = new ObservableCollection<string>
        {
            "Ivan Ivanov",
            "Alex Smith",
            "Maria Petrova"
        };
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}