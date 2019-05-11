using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.AbstractFactory.Abstract;
using Проект.AbstractFactory.Factory;
using Проект.AbstractFactory.Product;
namespace Проект.AbstractFactory
{
    class Client
    {
        private readonly Content _Local;
        private readonly Content _Local1;
        private readonly Content _Local2;
        private readonly Content _Local3;
        private readonly Content _Local4;
        /// ///////////////////////////////////////
        private readonly Content _Registry;
        private readonly Content _Registry1;
        private readonly Content _Registry2;
        private readonly Content _Registry3;
        private readonly Content _Registry4;
        private readonly Content _Registry5;
        private readonly Content _Registry6;
        private readonly Content _Registry7;
        private readonly Content _Registry8;
        /// ///////////////////////////////////////
        private readonly Content _T;
        private readonly Content _T1;
        private readonly Content _T2;
        private readonly Content _T3;
        private readonly Content _T4;
        private readonly Content _T5;
        private readonly Content _T6;
        private readonly Content _T7;
        private readonly Content _T8;
        /// ///////////////////////////////////////
        private readonly Content _TU;
        private readonly Content _TU1;
        private readonly Content _TU2;
        private readonly Content _TU3;
        private readonly Content _TU4;
        private readonly Content _TU5;
        private readonly Content _TU6;
        private readonly Content _TU7;
        private readonly Content _TU8;
        private readonly Content _TU9;

        public Client(IAllInAll factory)
        {
            _Local = factory.CreateLocal();
            _Local1 = factory.CreateLocal1();
            _Local2 = factory.CreateLocal2();
            _Local3 = factory.CreateLocal3();
            _Local4 = factory.CreateLocal4();
            _Registry = factory.CreateRegistry();
            _Registry1 = factory.CreateRegistry1();
            _Registry2 = factory.CreateRegistry2();
            _Registry3 = factory.CreateRegistry3();
            _Registry4 = factory.CreateRegistry4();
            _Registry5 = factory.CreateRegistry5();
            _Registry6 = factory.CreateRegistry6();
            _Registry7 = factory.CreateRegistry7();
            _Registry8 = factory.CreateRegistry8();
            _T = factory.CreateTicket();
            _T1 = factory.CreateTicket1();
            _T2 = factory.CreateTicket2();
            _T3 = factory.CreateTicket3();
            _T4 = factory.CreateTicket4();
            _T5 = factory.CreateTicket5();
            _T6 = factory.CreateTicket6();
            _T7 = factory.CreateTicket7();
            _T8 = factory.CreateTicket8();
            _TU = factory.CreateTicket();
            _TU1 = factory.CreateUTicket1();
            _TU2 = factory.CreateUTicket2();
            _TU3 = factory.CreateUTicket3();
            _TU4 = factory.CreateUTicket4();
            _TU5 = factory.CreateUTicket5();
            _TU6 = factory.CreateUTicket6();
            _TU7 = factory.CreateUTicket7();
            _TU8 = factory.CreateUTicket8();
            _TU9 = factory.CreateUTicket9();

        }
        ///////////////////////////////////////////////////////////////////
        public string InputYourLocal()
        {
            return _Local.LocLan();
        }
        public string InputYourLocal1()
        {
            return _Local1.LocLan1();
        }
        public string InputYourLocal2()
        {
            return _Local2.LocLan2();
        }
        public string InputYourLocal3()
        {
            return _Local3.LocLan3();
        }
        public string InputYourLocal4()
        {
            return _Local4.LocLan4();
        }
        ///////////////////////////////////////////////////////////////////
        public string InputYourRegistry()
        {
            return _Registry.LocR();
        }
        public string InputYourRegistry1()
        {
            return _Registry1.LocR1();
        }
        public string InputYourRegistry2()
        {
            return _Registry2.LocR2();
        }
        public string InputYourRegistry3()
        {
            return _Registry3.LocR3();
        }
        public string InputYourRegistry4()
        {
            return _Registry4.LocR4();
        }
        public string InputYourRegistry5()
        {
            return _Registry5.LocR5();
        }
        public string InputYourRegistry6()
        {
            return _Registry6.LocR6();
        }
        public string InputYourRegistry7()
        {
            return _Registry7.LocR7();
        }
        public string InputYourRegistry8()
        {
            return _Registry8.LocR8();
        }
        ///////////////////////////////////////////////////////////////////
        public string InputYourTicket()
        {
            return _T.LocT();
        }
        public string InputYourTicket1()
        {
            return _T1.LocT1();
        }
        public string InputYourTicket2()
        {
            return _T2.LocT2();
        }
        public string InputYourTicket3()
        {
            return _T3.LocT3();
        }
        public string InputYourTicket4()
        {
            return _T4.LocT4();
        }
        public string InputYourTicket5()
        {
            return _T5.LocT5();
        }
        public string InputYourTicket6()
        {
            return _T6.LocT6();
        }
        public string InputYourTicket7()
        {
            return _T7.LocT7();
        }
        public string InputYourTicket8()
        {
            return _T8.LocT8();
        }
        ///////////////////////////////////////////////////////////////////
        public string InputYourUTicket()
        {
            return _TU.LocTU();
        }
        public string InputYourUTicket1()
        {
            return _TU1.LocTU1();
        }
        public string InputYourUTicket2()
        {
            return _TU2.LocTU2();
        }
        public string InputYourUTicket3()
        {
            return _TU3.LocTU3();
        }
        public string InputYourUTicket4()
        {
            return _TU4.LocTU4();
        }
        public string InputYourUTicket5()
        {
            return _TU5.LocTU5();
        }
        public string InputYourUTicket6()
        {
            return _TU6.LocTU6();
        }
        public string InputYourUTicket7()
        {
            return _TU7.LocTU7();
        }
        public string InputYourUTicket8()
        {
            return _TU8.LocTU8();
        }
        public string InputYourUTicket9()
        {
            return _TU9.LocTU9();
        }
    }
    }
