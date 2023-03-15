using DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    public class AllUsersViewModel : BaseViewModel
    {
        public List<User> users { get; set; }

        public AllUsersViewModel()
        {
            using (FrontEndManager.TicketManager manager = new FrontEndManager.TicketManager())
            {
                users = manager.GetUSers().GetResponseData();
            }
        }

    }
}
