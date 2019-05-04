using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Classes
{
    class DiscountMaker
    {
        private IBuilder builder;
        public DiscountMaker(IBuilder builder)
        {
            this.builder = builder;
        }
        public void MakeDiscount(Ticket ticket, int Discount)
        {
            builder.AddWithDiscount(ticket, Discount);
        }
    }
}
