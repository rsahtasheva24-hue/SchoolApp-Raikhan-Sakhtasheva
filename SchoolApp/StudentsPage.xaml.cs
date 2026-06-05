using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();
        BindingContext = new StudentsViewModel();
    }

    private void OnAddStudentClicked(object sender, EventArgs e)
    {
        if (BindingContext is StudentsViewModel viewModel)
        {
            if (!string.IsNullOrWhiteSpace(viewModel.NewStudentName))
            {
                viewModel.Students.Add(viewModel.NewStudentName);
                viewModel.NewStudentName = string.Empty;
            }
        }
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is string studentName)
        {
            ((CollectionView)sender).SelectedItem = null;
            await Shell.Current.GoToAsync($"{nameof(StudentDetailPage)}?name={studentName}");
        }
    }
}