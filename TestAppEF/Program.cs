using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DbObjects;
using DbOperations.ResponseObject;
using DBOperations.Operations;
using TicketingService.Interface;

namespace TestAppEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITicketManagerService srv = CustomChannelFactory.CreateChannel<ITicketManagerService>();

            User u1 = new User() { User_Name = "Gulzaib", Creation_Date = System.DateTime.Today, Expiry_Date = System.DateTime.Today.AddDays(20) };
            ResponseObject<User> obj = srv.CreateUsers(u1);

            Route route = new Route() { Destinations = "ISL", Origin = "LHR" };
            ResponseObject<Route> obj1 = srv.AddRoutes(route);

            
            Ticket ticket = new Ticket() { Arrival = System.DateTime.Today, Departure = System.DateTime.Today.AddDays(1), BOOKED_BY = obj.GetResponseData().User_Id, Destination = "ISL", Origin = "LHR" };
            ResponseObject<Ticket> obj2 = srv.GenerateTickets(ticket);

            Console.WriteLine(obj._code);

            ResponseObject<List<Route>> routs =  srv.GetRoutes();
            ResponseObject<List<Ticket>> tickets =  srv.GetTickets();
            ResponseObject<List<User>> users = srv.GetUsers();


            foreach (var item in routs.GetResponseData())
            {
                Console.WriteLine(item.Route_Id + "  " + item.Origin + " " + item.Destinations + " \n\r"); 
            }


            foreach (var item in tickets.GetResponseData())
            {
                Console.WriteLine(item.Ticket_Id + "  " + item.Origin + " " + item.Destination + " " + item.TRAVLER_NAME + " " + item.Arrival + " " + item.Departure + " " + item.BOOKED_BY + " \n\r");
              
            }

            foreach (var item in users.GetResponseData())
            {
                Console.WriteLine(item.User_Id + "  " + item.User_Name + " \n\r");
            }

            Console.ReadLine();

        }
    }
}
