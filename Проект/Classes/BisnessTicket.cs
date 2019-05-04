using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Classes
{
    class BisnessTicket : TicketDecorator
    {
        public override DateTime Departure_date { get; set; }
        public override DateTime Arrive_date { get; set; }
        public override string From { get; set; }
        public override string To { get; set; }
        public override double Price { get{ return Price*1.25; } set { Price = value; } }
        public BisnessTicket(Ticket ticket) : base(ticket) { }
    }
}
