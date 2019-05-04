using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Abstract
{
    interface IBuilder
    {
        void AddWithDiscount(Ticket ticket, int Discount);
    }
    //<Label Content="Braus Airways" Foreground="White" FontSize="48" Margin="98.8,6.8,84.6,314.8" FontFamily="Viner Hand ITC" />
}
