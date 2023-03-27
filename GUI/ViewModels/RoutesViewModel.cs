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
    /// <summary>
    /// ViewModel class for Routes Screen
    /// </summary>
    public class RoutesViewModel : BaseViewModel
    {
        public string Origin { get; set; }
        public string Destinations { get; set; }
        public int Route_Id { get; set; }

        // Relay Command Pattern implementation
        public ICommand SaveRoutesCommand { get; set; }

        // Command initialization
        public RoutesViewModel()
        {
            SaveRoutesCommand = new SaveRoutesCommand(this);
        }

    }
}
