using DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    public class AllRoutesViewModel : BaseViewModel
    {
        public List<Route> routes { get; set; }

        public AllRoutesViewModel()
        {
            using (FrontEndManager.TicketManager manager = new FrontEndManager.TicketManager())
            {
                routes = manager.GetRoutes().GetResponseData();
            }
        }
    }
}
