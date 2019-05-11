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
    class Database_Registry
    {
        public string _name, _surname, _mail, _username, _password;
        public string _phone;
        public Database_Registry(string name, string surname, string phone, string mail, string username, string password)
        {
            _name = name;
            _surname = surname;
            _phone = phone;
            _mail = mail;
            _username = username;
            _password = password;
            Reg();
        }
        public void Reg()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Регистрация where Username = '" + _username + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Регистрация (Name, Surname,[Phone Number],[E-mail],[Username],Password)"
                        +
                        " VALUES(@Name, @Surname,@Phone,@Mail,@Username,@Password)", connection);
                    command.Parameters.AddWithValue("Name", _name);
                    command.Parameters.AddWithValue("Surname", _surname);
                    command.Parameters.AddWithValue("Phone", _phone);
                    command.Parameters.AddWithValue("Mail", _mail);
                    command.Parameters.AddWithValue("Username", _username);
                    command.Parameters.AddWithValue("Password", _password);
                    command.ExecuteNonQuery();
                    SqlCommand command1 = new SqlCommand("INSERT INTO Авторизация (Username,Password)" +
                        " VALUES(@Username,@Password)", connection);
                    command1.Parameters.AddWithValue("Username", _username);
                    command1.Parameters.AddWithValue("Password", _password);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Реєстрація пройдена успішно.");
                }
                else
                {
                    MessageBox.Show("Этот никнейм уже занят. Просим выбрать вас другой.");
                    MessageBox.Show("This Username is already used. please change it.");
                }
                connection.Close();
            }
        }

    }
}
