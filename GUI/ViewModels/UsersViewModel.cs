using GUI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.ViewModels
{
    public class UsersViewModel : BaseViewModel
    {
        public string User_Name { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Expiry_Date { get; set; }
        public int User_Id { get; set; }

        public ICommand SaveUsersCommand { get; set; }

        public UsersViewModel()
        {
            SaveUsersCommand = new SaveUsersCommand(this);
        }
    }
}
