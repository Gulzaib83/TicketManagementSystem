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
    [ServiceContract]
    public interface ITicketManagerService
    {
        [OperationContract]
        ResponseObject<List<User>> GetUsers();

        [OperationContract]
        ResponseObject<List<Route>> GetRoutes();

        [OperationContract]
        ResponseObject<List<Ticket>> GetTickets();


        [OperationContract]
        ResponseObject<User> CreateUsers(User user);

        [OperationContract]
        ResponseObject<Route> AddRoutes(Route route);

        [OperationContract]
        ResponseObject<Ticket> GenerateTickets(Ticket ticket);


    }
}
