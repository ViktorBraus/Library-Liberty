using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Abstract
{
    abstract class Ticket
    {
       public abstract DateTime Departure_date { get; set; }
       public abstract DateTime Arrive_date { get; set; }
       public abstract string  From { get; set; }
       public abstract string To { get; set; }
       public abstract double Price { get; set; }
    
    }
 }
