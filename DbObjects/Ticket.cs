//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<int> BOOKED_BY { get; set; }
        public string TRAVLER_NAME { get; set; }
        public int Ticket_Id { get; set; }
    }
}