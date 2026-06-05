using System.ComponentModel; 
using System.Runtime.CompilerServices; 

namespace SchoolApp.ViewModels;

public class Person : INotifyPropertyChanged
{
    
    private string _name = "Aida";
    private string _city = "Almaty";

    
    public event PropertyChangedEventHandler? PropertyChanged;

    
    public string Name
    {
        get => _name; 
        set
        {
            
            if (_name != value)
            {
                _name = value; 

                
                OnPropertyChanged();
            }
        }
    }

    
    public string City
    {
        get => _city;
        set
        {
            if (_city != value)
            {
                _city = value;

                
                OnPropertyChanged();
            }
        }
    }

    
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}