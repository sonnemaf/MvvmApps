using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ModelsLibrary.ViewModels;

// This must be a partial class, the CommunityToolkit.Mvvm
// Source Generator will add Properties to it.
public partial class MainViewModel : ObservableObject {

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(IncrementCommand))]
    private int _counter;

    [RelayCommand(CanExecute = nameof(CanIncrement))]
    private void Increment() {
        Counter++;
    }

    private bool CanIncrement => Counter < 10;
}