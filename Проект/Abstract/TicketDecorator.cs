using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Classes
{
    abstract class TicketDecorator : Ticket
    {
        protected Ticket ticket;
        public TicketDecorator(Ticket ticket)
        {
            this.ticket = ticket;
        }

    }
}
