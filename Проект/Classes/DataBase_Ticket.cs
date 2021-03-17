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
using Проект.Abstract;
using System.Data.SqlClient;
namespace Проект.Classes
{
    class DataBase_Ticket
    {
        Ticket ticket1;
        public string _Typeticket, _Username;
        public DataBase_Ticket(Ticket ticket, string username)
        {
            ticket1 = ticket;
            _Username = username;
            Ticket();
        }
        public void Ticket()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
            {
                connection.Open();
                var codeReader = 0;
                var codeBook = 0;
                SqlCommand command = new SqlCommand("Select distinct Код_ from Читачі where НікНейм ='"+ticket1.Нікнейм_Читача+"'", connection);
                SqlCommand command1 = new SqlCommand("Select distinct Код_к from Книги, Жанри where Автор = '"+ticket1.Автор+"'and Найменування_жанру = '"+ticket1.Жанр_книги+"'and Назва = '"+ticket1.Назва_книги+"'", connection);
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Видача_книг where Код_читача = '" + _Username + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataReader DR = command.ExecuteReader();
                while (DR.Read())
                {
                    codeReader = (int)DR[0];
                }
                DR.Close();
                SqlDataReader DR1 = command.ExecuteReader();
                while (DR1.Read())
                {
                    codeBook = (int)DR1[0];
                }
                DR1.Close();
                //SqlDataReader DR1 = command1.ExecuteReader();
                SqlCommand command2 = new SqlCommand("INSERT INTO Видача_Книг (Код_Книги, Код_Читача, Дата_Видачі, Очікувана_Дата_Здачі)" +
                        " VALUES(@codeBook, @codeReader, @DateOfIssuance,@ExpectedDay)", connection);
                    command2.Parameters.AddWithValue("codeBook", codeReader);
                    command2.Parameters.AddWithValue("codeReader", codeBook);
                    command2.Parameters.AddWithValue("DateOfIssuance", ticket1.Дата_Видачі);
                    command2.Parameters.AddWithValue("ExpectedDay", ticket1.Очікувана_Дата_Здачі);
                    command2.ExecuteNonQuery();
                //DR1.Close();
                connection.Close();
            }
        }

    }
}
