using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект.Abstract;
using Проект.Classes;
namespace Проект.Classes
{

    class Account
    {//Login = Username
        private static Account instance = null;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string NickName { get; set; } 
        public string Password { get; set; }
        public string TownFrom { get; set; }
        public string TownTo { get; set; }
        public string DateFrom { get; set; }
        public string Dateto { get; set; }
        public string TypeTicket { get; set; }
        public int Price { get; set; }
        public int Place { get; set; }
        // public bool isadmin { get; set; }
        private Account(
            string _Surname, 
            string _Name, 
            string _LastName, 
            string _Address, 
            string _Number, 
            string _NickName,
            string _Password)
        {
            Surname  = _Surname;
            Name     = _Name;
            LastName = _LastName;
            Address  = _Address;
            Number   = _Number;
            NickName = _NickName;
            Password = _Password;
        }
        public static Account GetInstance(string _Surname, string _Name, string _LastName, string _Address, string _Number, string NickName, string _Password)
        {
            if (instance == null)
                instance = new Account(_Surname, _Name, _LastName, _Address, _Number, NickName, _Password);
            return instance;
        }//@TownFrom, @TownTo, @DateFrom, @DateTo, @TypeTicket, @Price, @Place, @Username
        public static Account GetInstance1(string TownFrom, string TownTo, string DateFrom, string DateTo, string TypeTicket, int Price, int Place)
        {
            if (instance == null)
                instance = new Account(TownFrom, TownTo, DateFrom, DateTo, TypeTicket, Price.ToString(), Place.ToString());
            return instance;
        }

    }
}
