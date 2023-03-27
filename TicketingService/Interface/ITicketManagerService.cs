using DbObjects;
using DbOperations.ResponseObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TicketingService.Interface
{
    /// <summary>
    /// Service Contract for TicketMAnager Service
    /// </summary>
    [ServiceContract]
    public interface ITicketManagerService
    {
        /// <summary>
        /// Operation contract to get list of Users
        /// </summary>
        /// <returns>ResponseObject<List<User>></returns>
        [OperationContract]
        ResponseObject<List<User>> GetUsers();

        /// <summary>
        /// Operation contract to get list of Routes
        /// </summary>
        /// <returns>ResponseObject<List<Route>></returns>
        [OperationContract]
        ResponseObject<List<Route>> GetRoutes();

        /// <summary>
        /// Operation contract to get list of Tickets
        /// </summary>
        /// <returns>ResponseObject<List<Ticket>></returns>
        [OperationContract]
        ResponseObject<List<Ticket>> GetTickets();

        /// <summary>
        /// Operation contract to Create / Add new user in the system
        /// </summary>
        /// <returns>ResponseObject<User></returns> (newly created user with id value fetched from DB)
        [OperationContract]
        ResponseObject<User> CreateUsers(User user);

        /// <summary>
        /// Operation contract to Create / Add new route in the system
        /// </summary>
        /// <returns>ResponseObject<Route></returns> (newly created route with id value fetched from DB)
        [OperationContract]
        ResponseObject<Route> AddRoutes(Route route);

        /// <summary>
        /// Operation contract to Create / Add new Ticket in the system
        /// </summary>
        /// <returns>ResponseObject<List<Ticket>></returns> (newly created Ticket with id value fetched from DB)
        [OperationContract]
        ResponseObject<Ticket> GenerateTickets(Ticket ticket);


    }
}
