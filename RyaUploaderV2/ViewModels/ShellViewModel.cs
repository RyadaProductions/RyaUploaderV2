using System.ComponentModel;
using System.Windows;
using Stylet;

namespace RyaUploaderV2.ViewModels
{
    public class ShellViewModel : Screen
    {
        public object CurrentViewModel { get; set; }
        public TrayIconViewModel TrayIconViewModel { get; set; }
        
        public ShellViewModel(MainViewModel main, TrayIconViewModel trayIconViewModel)
        {
            CurrentViewModel = main;
            TrayIconViewModel = trayIconViewModel;
        }

        public void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            TrayIconViewModel.IsShellVisible = Visibility.Hidden;
        }
    }
}
