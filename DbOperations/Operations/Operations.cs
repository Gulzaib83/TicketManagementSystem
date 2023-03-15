using DbObjects;
using DbOperations.ResponseObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DBOperations.Operations
{
    public class Operations : IDisposable
    {
        public ResponseObject<User> CreateUser(User user)
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
			{
				using (var context = new TicketEntities())
				{
					context.Users.Add(user);
                    int affectedRows = context.SaveChanges();
                    
                    if (affectedRows > 0)
                    {
                        response.SetResponeData(user, ResultCode.Success, string.Empty);
                    }
                }
			}
			catch (Exception ex)
			{
                response.SetResponeData(user, ResultCode.Error, ex.Message);
                return response;
			}

			return response;
        }

        public ResponseObject<Route> AddRoute(Route route)
        {
            ResponseObject<Route> response = new ResponseObject<Route>();
            try
            {
                using (var context = new TicketEntities())
                {
                    context.Routes.Add(route);
                    int affectedRows = context.SaveChanges();

                    if (affectedRows > 0)
                    {
                        response.SetResponeData(route, ResultCode.Success, string.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                response.SetResponeData(route, ResultCode.Error, ex.Message);
                return response;

            }

            return response;
        }

        public ResponseObject<Ticket> GenerateTicket(Ticket ticket)
        {
            ResponseObject<Ticket> response = new ResponseObject<Ticket>();
            try
            {
               
                using (var context = new TicketEntities())
                {
                    context.Tickets.Add(ticket);
                    int affectedRows = context.SaveChanges();
                    //int id = ticket.Ticket_Id;
                                        
                    if (affectedRows > 0)
                    {
                        response.SetResponeData(ticket, ResultCode.Error, string.Empty);
                    }
                        
                }
            }
            catch (Exception ex)
            {
                response.SetResponeData(ticket, ResultCode.Success, ex.Message);
                return response;
            }

            return response;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<User> GetUsers()
        {
            List<User> users;
            try
            {
                using (var context = new TicketEntities())
                {
                    users = context.Users.ToList();
                    return users;
                }
            }
            catch (Exception ex)
            {
                return null;   
            }

            
        }

        public List<Route> GetRoutes()
        {
            List<Route> routes;
            try
            {
                using (var context = new TicketEntities())
                {
                    routes = context.Routes.ToList();
                    return routes;
                }
            }
            catch (Exception ex)
            {
                return null;
            }


        }

        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets;
            try
            {
                using (var context = new TicketEntities())
                {
                    tickets = context.Tickets.ToList();
                    return tickets;
                }
            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}
