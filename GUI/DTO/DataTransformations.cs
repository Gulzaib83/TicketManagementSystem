using DbObjects;
using GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public static class DataTransformations
    {
        public static User UserVmToUser(UsersViewModel viewModel)
        {
            User user = new User();
            user.User_Name= viewModel.User_Name;
            user.Creation_Date = viewModel.Creation_Date;
            user.Expiry_Date = viewModel.Expiry_Date;
            user.User_Id = viewModel.User_Id;

            return user;
        }

        public static Route RoutesVmToRoutes(RoutesViewModel viewModel)
        {
            Route route = new Route();
            route.Origin = viewModel.Origin;
            route.Destinations = viewModel.Destinations;
            route.Route_Id = viewModel.Route_Id;

            return route;
        }

        public static Ticket TicketsVmToTicket(TicketsViewModel viewModel)
        {
            Ticket ticket = new Ticket();
            ticket.Arrival = viewModel.Arrival;
            ticket.Departure = viewModel.Departure;
            ticket.Origin = viewModel.Origin.ToString();
            ticket.Destination = viewModel.Destination.ToString();
            ticket.TRAVLER_NAME = viewModel.TRAVLER_NAME;
            ticket.BOOKED_BY = viewModel.BOOKED_BY;

            return ticket;
        }
    }
}
