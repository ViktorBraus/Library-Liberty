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
       public abstract string Назва_книги { get; set; }
       public abstract string Жанр_книги { get; set; }
       public abstract string Автор { get; set; }
       public abstract string Нікнейм_Читача { get; set; }
       public abstract DateTime Дата_Видачі { get; set; }
       public abstract DateTime Очікувана_Дата_Здачі { get; set; }
       public abstract DateTime Фактична_Дата_Здачі { get; set; }
       public abstract double Сумма_Штрафів { get; set; }
    }
 }
