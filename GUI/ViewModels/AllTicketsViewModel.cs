using DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    public class AllTicketsViewModel : BaseViewModel
    {
        public List<Ticket> tickets { get; set; }

        public AllTicketsViewModel()
        {
            using (FrontEndManager.TicketManager manager = new FrontEndManager.TicketManager())
            {
                tickets = manager.GetTickets().GetResponseData();
            }
        }
    }
}
