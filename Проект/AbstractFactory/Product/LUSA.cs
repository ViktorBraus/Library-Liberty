using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.AbstractFactory.Factory;
using Проект.AbstractFactory.Abstract;
namespace Проект.AbstractFactory.Product
{
    class LUSA : Content
    {
        public override string LocLan()
        {
            return "Username";
        }
        public override string LocLan1()
        {
            return "Password";
        }
        public override string LocLan2()
        {
            return "Login";
        }
        public override string LocLan3()
        {
            return "Registry";
        }
        public override string LocLan4()
        {
            return "Exit";
        }
        ///////////////////////////////////////////////////////////////////
        public override string LocR()
        {
            return "Name";
        }
        public override string LocR1()
        {
            return "Surname";
        }
        public override string LocR2()
        {
            return "Phone Number";
        }
        public override string LocR3()
        {
            return "E-mail";
        }
        public override string LocR4()
        {
            return "NickName";
        }
        public override string LocR5()
        {
            return "Password";
        }
        public override string LocR6()
        {
            return "Repeat Password";
        }
        public override string LocR7()
        {
            return  "    Home";
        }
        public override string LocR8()
        {
            return "   Submit";
        }
        ///////////////////////////////////////////////////////////////////
        public override string LocT()
        {
            return "Departure City";
        }
        public override string LocT1()
        {
            return "Arrival City";
        }
        public override string LocT2()
        {
            return "Departure Time";
        }
        public override string LocT3()
        {
            return "Arrival Time";
        }
        public override string LocT4()
        {
            return "Ticket Type";
        }
        public override string LocT5()
        {
            return "Price";
        }
        public override string LocT6()
        {
            return "Seat";
        }
        public override string LocT7()
        {
            return "        Delete";
        }
        public override string LocT8()
        {
            return "       Update";
        }
        ///////////////////////////////////////////////////////////////////
        public override string LocTU()
        {
            return "Departure City";
        }
        public override string LocTU1()
        {
            return "Arrival City";
        }
        public override string LocTU2()
        {
            return "Departure Time";
        }
        public override string LocTU3()
        {
            return "Arrival Time";
        }
        public override string LocTU4()
        {
            return "Ticket Type";
        }
        public override string LocTU5()
        {
            return "Price";
        }
        public override string LocTU6()
        {
            return "Seat";
        }
        public override string LocTU7()
        {
            return "       Home";
        }
        public override string LocTU8()
        {
            return "       Buy";
        }
        public override string LocTU9()
        {
            return "T   i   c   k   e   t                   O     r   d   e   r   i   n   g";
        }
        //
    }
}
