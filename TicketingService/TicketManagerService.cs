using DbObjects;
using DbOperations.ResponseObject;
using DBOperations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingService.Interface;

namespace TicketingService
{
    public class TicketManagerService : ITicketManagerService
    {
        public ResponseObject<Route> AddRoutes(Route route)
        {
            ResponseObject<Route> response = new ResponseObject<Route>();
            try
            {
                using (Operations op = new Operations())
                {
                    response = op.AddRoute(route);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return response;
        }

        public ResponseObject<User> CreateUsers(User user)
        {
            ResponseObject<User> response = new ResponseObject<User>();
            try
            {
                using (Operations op = new Operations())
                {
                    response = op.CreateUser(user);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return response;
        }

        public ResponseObject<Ticket> GenerateTickets(Ticket ticket)
        {
            ResponseObject<Ticket> response = new ResponseObject<Ticket>();
            try
            {
                using (Operations op = new Operations())
                {
                    response = op.GenerateTicket(ticket);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return response;
        }

        public ResponseObject<List<Route>> GetRoutes()
        {
            ResponseObject<List<Route>> response = new ResponseObject<List<Route>>();
            
            try
            {
                using (Operations op = new Operations())
                {
                    List<Route> routes = new List<Route>();
                    routes = op.GetRoutes();
                    response.SetResponeData(routes, ResultCode.Success, "");
                }
            }
            catch (Exception ex)
            {
                response.SetResponeData(null, ResultCode.Error, ex.Message);
            }
            finally
            {

            }
            return response;
        }

        public ResponseObject<List<Ticket>> GetTickets()
        {
            ResponseObject<List<Ticket>> response = new ResponseObject<List<Ticket>>();
            
            try
            {
                using (Operations op = new Operations())
                {
                    List<Ticket> tickets = new List<Ticket>();
                    tickets = op.GetTickets();
                    response.SetResponeData(tickets, ResultCode.Success, "");
                }
            }
            catch (Exception ex)
            {
                response.SetResponeData(null, ResultCode.Error, ex.Message);
            }
            finally
            {

            }
            return response;
        }

        public ResponseObject<List<User>> GetUsers()
        {
            ResponseObject<List<User>> response = new ResponseObject<List<User>>();
            try
            {
                using (Operations op = new Operations())
                {
                    List<User> users = new List<User>();
                    users = op.GetUsers();
                    response.SetResponeData(users, ResultCode.Success, "");
                }
            }
            catch(Exception ex)
            {
                response.SetResponeData(null, ResultCode.Error, ex.Message);
            }
            finally
            {
                
            }
            return response;
        }
    }
}
