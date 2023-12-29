using ModelsLibrary.ViewModels;

namespace WinFormsMvvmApp.Views.Forms; 

public partial class Form1 : Form {

    private readonly MainViewModel _vm;

    public Form1() {
        InitializeComponent();

        _vm = new MainViewModel();

        var binding = labelCounter.DataBindings.Add(nameof(labelCounter.Text), _vm, nameof(_vm.Counter));
        binding.FormatString = "C2";
        binding.FormattingEnabled = true;

        buttonIncrement.Command = _vm.IncrementCommand;
    }
}
