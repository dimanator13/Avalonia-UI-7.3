using System.Collections.ObjectModel;

namespace Task_3.ViewModels;

public class TasksViewModel : ViewModelBase
{
    public string Title => "Tasks screen";

    public ObservableCollection<string> Tasks { get; } = new()
    {
        "Learn navigation",
        "Understand ContentControl",
        "Understand DataTemplate"
    };
}