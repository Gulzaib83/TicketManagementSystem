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
    public class TicketManager : IDisposable
    {
        public TicketManager()
        {

        }

        public ResponseObject<User> CreateUser(User user)
        {
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<User> addedUser = srv.CreateUsers(user);

            return addedUser;
        }
        
        public ResponseObject<Route> AddRoutes(Route route)
        {
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<Route> addedRoute = srv.AddRoutes(route);

            return addedRoute;    
        }
        
        public ResponseObject<Ticket> GenerateTickets(Ticket ticket)
        {
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<Ticket> addedTicket = srv.GenerateTickets(ticket);
            return addedTicket;
        }

        public ResponseObject<List<Route>> GetRoutes()
        {
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<List<Route>> routs = srv.GetRoutes();
            return routs;
        }
        
        public ResponseObject<List<Ticket>> GetTickets()
        {
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<List<Ticket>> tickets = srv.GetTickets();
            return tickets;
        }

        public ResponseObject<List<User>> GetUSers()
        {
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();
            ResponseObject<List<User>> users = srv.GetUsers();
            return users;
        }

        public void Dispose()
        {
            
        }
    }
}
