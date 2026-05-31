using CommunityToolkit.Mvvm.ComponentModel;

namespace Task_3.ViewModels;


public partial class SettingsViewModel : ViewModelBase
{
    public string Title => "Settings screen";

    [ObservableProperty]
    private string _userName = "User";

    [ObservableProperty]
    private bool _showHints = true;
}