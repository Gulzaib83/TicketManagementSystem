using GUI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.ViewModels
{
    public  class TicketsViewModel : BaseViewModel
    {

        public string Origin { get; set; }
        public string Destination { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<int> BOOKED_BY { get; set; }
        public string TRAVLER_NAME { get; set; }
        public int Ticket_Id { get; set; }

        public ICommand SaveTicketsCommand { get; set; }    
        
        public TicketsViewModel()
        {
            SaveTicketsCommand = new SaveTicketsCommand(this);
        }
    }
}
