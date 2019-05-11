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
        public string Number { get; set; }
        public string Email { get; set; }
        public string Login { get; set; } 
        public string Password { get; set; }
        public string Username { get; set; }
        public string TownFrom { get; set; }
        public string TownTo { get; set; }
        public string DateFrom { get; set; }
        public string Dateto { get; set; }
        public string TypeTicket { get; set; }
        public int Price { get; set; }
        public string Place { get; set; }
        // public bool isadmin { get; set; }
        private Account(string _Name, string _Surname, string _Number, string _Email, string _Login, string _Password, string _Username)
        {
            Name = _Name;
            Surname = _Surname;
            Number = _Number;
            Email = _Email;
            Login = _Login;
            Password = _Password;
            Username = _Username;
        }
        public static Account GetInstance(string _Name, string _Surname, string _Number, string _Email, string _Login, string _Password)
        {
            if (instance == null)
                instance = new Account( _Name, _Surname,  _Number,  _Email,  _Login,  _Password, null);
            return instance;
        }//@TownFrom, @TownTo, @DateFrom, @DateTo, @TypeTicket, @Price, @Place, @Username
        public static Account GetInstance1(string TownFrom, string TownTo, string DateFrom, string DateTo, string TypeTicket, int Price, string Username)
        {
            if (instance == null)
                instance = new Account(TownFrom, TownTo, DateFrom, DateTo, TypeTicket, Price.ToString(), Username);
            return instance;
        }

    }
}
