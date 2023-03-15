using GUI.Commands;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.ViewModels
{
    public class RoutesViewModel : BaseViewModel
    {
        public string Origin { get; set; }
        public string Destinations { get; set; }
        public int Route_Id { get; set; }

        public ICommand SaveRoutesCommand { get; set; }

        public RoutesViewModel()
        {
            SaveRoutesCommand = new SaveRoutesCommand(this);
        }

    }
}
