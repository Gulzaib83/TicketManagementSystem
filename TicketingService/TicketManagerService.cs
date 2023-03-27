using DbObjects;
using DbOperations.ResponseObject;
using DBOperations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using TicketingService.Interface;

namespace TicketingService
{
    /// <summary>
    /// Actual implementation of ITicketManagerService Service Contract.
    /// This class is implementing ITicketManagerService.
    /// Basic purpose of this implementation is to provide communication mechanism between Front End and DAL.
    /// </summary>
    public class TicketManagerService : ITicketManagerService
    {
        public ResponseObject<Route> AddRoutes(Route route)
        {
            ResponseObject<Route> response = new ResponseObject<Route>();
            try
            {
                //Memory management
                using (Operations op = new Operations())
                {
                    // Operations class is the part of DAL layer where all Databse related operations are carried out.
                    // Here we call AddRoute method of DAL -> Operations and it will perform Database interaction (Insert data into Routes)
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
                //Memory management
                using (Operations op = new Operations())
                {
                    // Operations class is the part of DAL layer where all Databse related operations are carried out.
                    // Here we call CreateUser method of DAL -> Operations and it will perform Database interaction (Insert data into User)
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
            //Memory management
            ResponseObject<Ticket> response = new ResponseObject<Ticket>();
            try
            {
                using (Operations op = new Operations())
                {
                    // Operations class is the part of DAL layer where all Databse related operations are carried out.
                    // Here we call GenerateTicket method of DAL -> Operations and it will perform Database interaction (Insert data into Tikcets)
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
                //Memory management
                using (Operations op = new Operations())
                {
                    List<Route> routes = new List<Route>();
                    // Operations class is the part of DAL layer where all Databse related operations are carried out.
                    // Here we call GetRoutes method of DAL -> Operations and it will perform Database interaction (Read data from Routes)
                    routes = op.GetRoutes();

                    //Setting ResponseObject with correct DataType and ResultCode of Success
                    response.SetResponeData(routes, ResultCode.Success, "");
                }
            }
            catch (Exception ex)
            {
                //Setting ResponseObject with ResultCode of Failure and exact Exception message for further handling and different layer
                //where error handling is taking place
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
                //Memory management
                using (Operations op = new Operations())
                {
                    List<Ticket> tickets = new List<Ticket>();
                    // Operations class is the part of DAL layer where all Databse related operations are carried out.
                    // Here we call GetTickets method of DAL -> Operations and it will perform Database interaction (Read data from Tickets)
                    tickets = op.GetTickets();
                    response.SetResponeData(tickets, ResultCode.Success, "");
                }
            }
            catch (Exception ex)
            {
                // Setting ResponseObject with ResultCode of Failure and exact Exception message for further handling and different layer
                // where error handling is taking place
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
                //Memory management
                using (Operations op = new Operations())
                {
                    List<User> users = new List<User>();
                    // Operations class is the part of DAL layer where all Databse related operations are carried out.
                    // Here we call GetUsers method of DAL -> Operations and it will perform Database interaction (Read data from Users)
                    users = op.GetUsers();
                    response.SetResponeData(users, ResultCode.Success, "");
                }
            }
            catch(Exception ex)
            {
                // Setting ResponseObject with ResultCode of Failure and exact Exception message for further handling and different layer
                // where error handling is taking place
                response.SetResponeData(null, ResultCode.Error, ex.Message);
            }
            finally
            {
                
            }
            return response;
        }
    }
}
