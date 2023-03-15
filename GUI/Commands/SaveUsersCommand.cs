using GUI.DTO;
using GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.Commands
{
    public class SaveUsersCommand : ICommand
    {
        private UsersViewModel viewModel;

        public SaveUsersCommand(UsersViewModel viewModel)
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
            using (FrontEndManager.TicketManager manager = new FrontEndManager.TicketManager())
            {

                manager.CreateUser(DataTransformations.UserVmToUser(viewModel));
            }
        }
    }
}
