using GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Users")
            {
                viewModel.SelectedViewModel = new UsersViewModel();
            }
            else if (parameter.ToString() == "Tickets")
            {
                viewModel.SelectedViewModel = new TicketsViewModel();
            }
            else if (parameter.ToString() == "Routes")
            {
                viewModel.SelectedViewModel = new RoutesViewModel();
            }
            else if (parameter.ToString() == "UsersList")
            {
                viewModel.SelectedViewModel = new AllUsersViewModel();
            }
            else if (parameter.ToString() == "TicketsList")
            {
                viewModel.SelectedViewModel = new AllTicketsViewModel();
            }
            else if (parameter.ToString() == "RoutesList")
            {
                viewModel.SelectedViewModel = new AllRoutesViewModel();
            }
        }

    }
}
