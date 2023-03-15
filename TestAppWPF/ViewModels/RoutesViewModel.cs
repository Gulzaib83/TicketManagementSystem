using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TestAppWPF.Command;
using TestAppWPF.Views;

namespace TestAppWPF.ViewModels
{
    internal class RoutesViewModel : ViewModelBase
    {
        public ICommand GoToUserPageCommand { get; set; }
        public ICommand GoToTicketsPageCommand { get; set; }

        public RoutesViewModel()
        {
            GoToUserPageCommand = new RelayCommand(GoToUserPage);
            GoToTicketsPageCommand = new RelayCommand(GoToTicketsPage);
        }

        private void GoToUserPage()
        {
            // Navigate to AboutPage
            var mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.Navigate(new CreateUsers());
        }

        private void GoToTicketsPage()
        {
            // Navigate to SettingsPage
            var mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.Navigate(new Tickets());
        }
    }
}
