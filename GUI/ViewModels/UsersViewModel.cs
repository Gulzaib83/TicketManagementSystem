using GUI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.ViewModels
{
    /// <summary>
    /// ViewModel class for Users Screen
    /// </summary>
    public class UsersViewModel : BaseViewModel
    {
        public string User_Name { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public int User_Id { get; set; }

        // Relay Command Pattern implementation
        public ICommand SaveUsersCommand { get; set; }

        // Command initialization
        public UsersViewModel()
        {
            SaveUsersCommand = new SaveUsersCommand(this);
        }
    }
}
