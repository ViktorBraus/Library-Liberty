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
    {
        private static Account instance = null;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isadmin { get; set; }
        
        public static Account GetInstance()
        {
            if (instance == null)
                instance = new Account();
            return instance;
        }

    }
}
