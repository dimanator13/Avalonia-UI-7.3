using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Task_3.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public HomeViewModel HomeViewModel { get; }

    public TasksViewModel TasksViewModel { get; }

    public SettingsViewModel SettingsViewModel { get; }

    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    public MainWindowViewModel()
    {
        HomeViewModel = new HomeViewModel();
        TasksViewModel = new TasksViewModel();
        SettingsViewModel = new SettingsViewModel();

        CurrentViewModel = HomeViewModel;
    }

    [RelayCommand]
    private void ShowHome()
    {
        CurrentViewModel = HomeViewModel;
    }

    [RelayCommand]
    private void ShowTasks()
    {
        CurrentViewModel = TasksViewModel;
    }

    [RelayCommand]
    private void ShowSettings()
    {
        CurrentViewModel = SettingsViewModel;
    }
}