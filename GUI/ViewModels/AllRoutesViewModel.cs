using DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    /// <summary>
    /// ViewModel for AllRoutes screen
    /// </summary>
    public class AllRoutesViewModel : BaseViewModel
    {
        public List<Route> routes { get; set; }

        public AllRoutesViewModel()
        {
            using (FrontEndManager.TicketManager manager = new FrontEndManager.TicketManager())
            {
                // Fetch data by calling Front End Manager class
                routes = manager.GetRoutes().GetResponseData();
            }
        }
    }
}
