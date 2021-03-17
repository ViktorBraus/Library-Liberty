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
    class Database_Authorization
    {

        public string _password, _nickname;
        public Database_Authorization(string NickName, string Password)
        {
            _nickname = NickName;
            _password = Password;
            Log();
        }
        public void Log()
        {
            Account account = Account.GetInstance(null,null,null,null,null, _nickname, _password);
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
            {
                
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Читачі where НікНейм = '" + account.NickName + "' and Пароль = '" + account.Password + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show($"Good Day, {_nickname}.");
                    MessageBox.Show($"Доброго дня, {_nickname}.");
                    /*UserTicket a = new UserTicket();
                    a.Show();
                    a1.Close();*/

                }
                else
                {

                }
                connection.Close();
            }
        }
    }
}
