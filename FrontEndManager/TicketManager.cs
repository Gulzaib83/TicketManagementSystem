using DbObjects;
using DbOperations.ResponseObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingService.Interface;

namespace FrontEndManager
{
    /// <summary>
    /// This class provides implementaion to act as intermediary between WCF and Client
    /// This class will create the Channel for WCF service and then call the relevant Service method
    /// This project is added in Client application as DLL.
    /// </summary>
    public class TicketManager : IDisposable
    {
        public TicketManager()
        {

        }

        public ResponseObject<User> CreateUser(User user)
        {
            // Create Channel from CustomChannelFactory for WCF service, After this we can directly create Object of ITicketManagerService and call desired method
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<User> addedUser = srv.CreateUsers(user);

            return addedUser;
        }
        
        public ResponseObject<Route> AddRoutes(Route route)
        {
            // Create Channel from CustomChannelFactory for WCF service, After this we can directly create Object of ITicketManagerService and call desired method
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<Route> addedRoute = srv.AddRoutes(route);

            return addedRoute;    
        }
        
        public ResponseObject<Ticket> GenerateTickets(Ticket ticket)
        {
            // Create Channel from CustomChannelFactory for WCF service, After this we can directly create Object of ITicketManagerService and call desired method
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<Ticket> addedTicket = srv.GenerateTickets(ticket);
            return addedTicket;
        }

        public ResponseObject<List<Route>> GetRoutes()
        {
            // Create Channel from CustomChannelFactory for WCF service, After this we can directly create Object of ITicketManagerService and call desired method
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<List<Route>> routs = srv.GetRoutes();
            return routs;
        }
        
        public ResponseObject<List<Ticket>> GetTickets()
        {
            // Create Channel from CustomChannelFactory for WCF service, After this we can directly create Object of ITicketManagerService and call desired method
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<List<Ticket>> tickets = srv.GetTickets();
            return tickets;
        }

        public ResponseObject<List<User>> GetUSers()
        {
            // Create Channel from CustomChannelFactory for WCF service, After this we can directly create Object of ITicketManagerService and call desired method
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<List<User>> users = srv.GetUsers();
            return users;
        }

        public void Dispose()
        {
            
        }
    }
}
