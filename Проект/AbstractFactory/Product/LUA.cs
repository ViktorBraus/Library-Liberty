using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.AbstractFactory.Factory;
using Проект.AbstractFactory.Abstract;
namespace Проект.AbstractFactory.Product
{
    class LUA : Content
    {
        public override string LocLan()
        {
            return "НікНейм";
        }
        public override string LocLan1()
        {
            return "Пароль";
        }
        public override string LocLan2()
        {
            return "  Вхід";
        }
        public override string LocLan3()
        {
            return "Реєстрація";
        }
        public override string LocLan4()
        {
            return "Вихід";
        }
        ///////////////////////////////////////////////////////////////////Реєстрація
        public override string LocR()
        {
            return "Прізвище";
        }
        public override string LocR1()
        {
            return "Ім'я";
        }
        public override string LocR2()
        {
            return "По-Батькові";
        }
        public override string LocR3()
        {
            return "Адреса проживання";
        }
        public override string LocR4()
        {
            return "Номер телефону";
        }
        public override string LocR5()
        {
            return "Нікнейм";
        }
        public override string LocR6()
        {
            return "Пароль";
        }
        public override string LocR7()
        {
            return "Повторний Пароль";
        }
        public override string LocR8()
        {
            return "Підтвердити";
        }
        public override string LocR9()
        {
            return "  Головна";
        }
        ///////////////////////////////////////////////////////////////////Адмін панель
        public override string LocT()
        {
            return "Прізвище";
        }
        public override string LocT1()
        {
            return "Ім'я";
        }
        public override string LocT2()
        {
            return "По-Батькові";
        }
        public override string LocT3()
        {
            return "Адреса проживання";
        }
        public override string LocT4()
        {
            return "Номер телефону";
        }
        public override string LocT5()
        {
            return "Нікнейм";
        }
        public override string LocT6()
        {
            return "Пароль";
        }
        public override string LocT7()
        {
            return "    Видалити";
        }
        public override string LocT8()
        {
            return "    Оновити";
        }
        public override string LocT9()
        {
            return "Читачі";
        }
        public override string LocT10()
        {
            return "Книги";
        }
        public override string LocT11()
        {
            return "Видача книг";
        }
        ///////////////////////////////////////////////////////////////////
        public override string LocTU()
        {
            return "Місто Відправлення";
        }
        public override string LocTU1()
        {
            return "Місто Прибуття";
        }
        public override string LocTU2()
        {
            return "Дата Відправлення";
        }
        public override string LocTU3()
        {
            return "Дата Прибуття";
        }
        public override string LocTU4()
        {
            return "Ціна за квиток";
        }
        public override string LocTU5()
        {
            return "Тип Квитка";
        }
        public override string LocTU6()
        {
            return "Посадкове місце";
        }
        public override string LocTU7()
        {
            return "    Головна";
        }
        public override string LocTU8()
        {
            return "   Замовити";
        }
        public override string LocTU9()
        {
            return "   П   р   о   к   а   т            К   н   и   г   и";
        }
        //////////////////////////////////////
    }
}
