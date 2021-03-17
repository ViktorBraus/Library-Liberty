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
        public string _surname, _name, _lastname, _address, _number, _nickname, _password;
        public Database_Registry(string surname, string name, string lastname, string address, string number, string nickname, string password)
        {
            _surname = surname;
            _name = name;
            _lastname = lastname;
            _address = address;
            _number = number;
            _nickname = nickname;
            _password = password;
            Reg();
        }
        public void Reg()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Читачі where НікНейм = '" + _nickname + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Читачі (Прізвище, [Імя], По_батькові, Адреса, Телефон, НікНейм, Пароль)"
                        +
                        " VALUES(@Surname, @Name,@LastName,@Address,@Number,@NickName,@Password)", connection);
                    command.Parameters.AddWithValue("Surname", _surname);
                    command.Parameters.AddWithValue("Name", _name);
                    command.Parameters.AddWithValue("LastName", _lastname);
                    command.Parameters.AddWithValue("Address", _address);
                    command.Parameters.AddWithValue("Number", _number);
                    command.Parameters.AddWithValue("NickName", _nickname);
                    command.Parameters.AddWithValue("Password", _password);
                    command.ExecuteNonQuery();
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
