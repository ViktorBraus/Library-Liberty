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
    class DataBase_Ticket
    {
        public string _TownFrom, _TownTo, _DateFrom, _DateTo, _Typeticket, _Place, _Username;
        public int _price;
        public DataBase_Ticket(string TownFrom, string TownTo, string DateFrom, string DateTo, string TypeTicket, int price, string Place, string Username)
        {
            _TownFrom = TownFrom;
            _TownTo = TownTo;
            _DateFrom = DateFrom;
            _DateTo = DateTo;
            _Typeticket = TypeTicket;
            _price = price;
            _Place = Place;
            _Username = Username;
            Ticket();
        }
        public void Ticket()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From БилетЮзер where [Имя Пассажира] = '" + _Username + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                    SqlCommand command = new SqlCommand("INSERT INTO БилетЮзер ([Город Отправления], [Город Прибытия],[Дата Отправления],[Дата Прибытия],[Тип Билета],[Цена за билет], [Посадочное Место], [Имя Пассажира])" +
                        " VALUES(@_TownFrom, @_TownTo, @_DateFrom,@_DateTo,@_Typeticket,@_price, @_Place, @_Username)", connection);
                    command.Parameters.AddWithValue("_TownFrom", _TownFrom);
                    command.Parameters.AddWithValue("_TownTo", _TownTo);
                    command.Parameters.AddWithValue("_DateFrom", _DateFrom);
                    command.Parameters.AddWithValue("_DateTo", _DateTo);
                    command.Parameters.AddWithValue("_Typeticket", _Typeticket);
                    command.Parameters.AddWithValue("_price", _price);
                    command.Parameters.AddWithValue("_Place", _Place);
                    command.Parameters.AddWithValue("_Username", _Username);
                    command.ExecuteNonQuery();
                connection.Close();
            }

        }
    }
}
