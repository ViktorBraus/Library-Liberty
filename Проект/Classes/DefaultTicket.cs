using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Classes
{
    class DefaultTicket : Ticket
    {
        public override string Назва_книги { get; set; }
        public override string Жанр_книги { get; set; }
        public override string Автор { get; set; }
        public override string Нікнейм_Читача { get; set; }
        public override DateTime Дата_Видачі { get; set; }
        public override DateTime Очікувана_Дата_Здачі { get; set; }
        public override DateTime Фактична_Дата_Здачі { get; set; }
        public override double Сумма_Штрафів { get; set; }
        public DefaultTicket () : base() { }
      

    }
}
