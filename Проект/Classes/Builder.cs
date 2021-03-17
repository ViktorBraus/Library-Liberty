using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Classes
{
    class Builder : IBuilder
    {
        private List<Ticket> Tickets = new List<Ticket>();
        public void AddWithDiscount(Ticket ticket, int Discount)
        {
            //ticket.Price -= ticket.Price * Discount / 100;
            //Tickets.Add(ticket);
        }
        public List<Ticket> GetTickets() { return Tickets; }
    }
}
