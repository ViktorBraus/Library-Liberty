using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using Проект.AbstractFactory.Abstract;
using Проект.AbstractFactory.Factory;
using Проект.AbstractFactory.Product;
using Проект.AbstractFactory;
using System.Data.SqlClient;
namespace Проект.Classes
{
    class Database_Authorization : MainWindow
    {
        MainWindow a1 = new MainWindow();
        public string _name, _surname, _mail, _username, _password;
        public string _phone;
        public Database_Authorization(string Username, string Password)
        {
            _username = Username;
            _password = Password;
            Log();
        }
        public void Log()
        {
            Account account = Account.GetInstance(_name, _surname, _phone,_mail, _username, _password);
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
            {
                
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Авторизация where Username = '" + account.Login + "' and Password = '" + account.Password + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show($"Good Day, {_username}.");
                    MessageBox.Show($"Доброго дня, {_username}.");
                    UserTicket a = new UserTicket();
                    a.Show();
                    a1.Close();
                }
                else
                {
                    MessageBox.Show("Невірні Дані. Будь Ласка, пробуйте ще.");
                    MessageBox.Show("Invalid Data. please Retry.");
                   
                }
                connection.Close();
            }
        }
    }
}
