using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Data;
using System.Data.SqlClient;
using Проект.Classes;
namespace Проект
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string _Name, Phone, Mail, Surname, Password;
        public string _Username, _Password;
        private void CustomWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        public FillBehavior Timespan { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if ((_q1.Text != "") && (_q2.Password != ""))
            {
                Account account = Account.GetInstance( Name, Surname, Phone, Mail, _q1.Text, _q2.Password);
                account.Password = _q2.Password;
               using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand CheckInBase = new SqlCommand("SELECT Username FROM Авторизация WHERE Username = 'admin'", connection);
                    SqlDataReader reader = CheckInBase.ExecuteReader();
                    if (reader.Read()&&(_q1.Text=="admin"))
                    {
                        MessageBox.Show("Admin");
                        TicketSale a = new TicketSale();
                        a.Show();
                        this.Close();
                    }
                    else
                    {
                        reader.Close();
                        SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Авторизация where Username = '" + _q1.Text + "' and Password = '" + _q2.Password + "'", connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Database_Authorization start = new Database_Authorization(account.Login, account.Password);
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Невірні Дані1324. Будь Ласка, пробуйте ще.");
                            MessageBox.Show("Invalid Data. please Retry.");
                            _q1.Text = null;
                            _q2.Password = null;
                        }
                        this.Close();
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("There is no data. please, write down your username and password.");
                MessageBox.Show("Дані не введені. Увведіть дані.");
                _q1.Text = null;
                _q2.Password = null;
            }
            
        }
        private void EscButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // закрытие окна
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registry a = new Registry();
            a.Show();
            this.Close();
        }
        private void Login2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(104, TimeSpan.FromMilliseconds(300));
            Login1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(75, TimeSpan.FromMilliseconds(300));
            Login1.BeginAnimation(HeightProperty, a1);
        }
        private void Login3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(100, TimeSpan.FromMilliseconds(500));
            Login1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Login1.BeginAnimation(HeightProperty, a1);
        }
        private void Exit2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(98, TimeSpan.FromMilliseconds(300));
            Exit1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(76, TimeSpan.FromMilliseconds(300));
            Exit1.BeginAnimation(HeightProperty, a1);
        }
        private void Exit3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(95, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(HeightProperty, a1);
        }
        private void Registry2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(139, TimeSpan.FromMilliseconds(300));
            Registry1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(76, TimeSpan.FromMilliseconds(300));
            Registry1.BeginAnimation(HeightProperty, a1);
        }
        private void Registry3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(134, TimeSpan.FromMilliseconds(500));
            Registry1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Registry1.BeginAnimation(HeightProperty, a1);
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Client USABoy = new Client(new USA());
            q1.Content = USABoy.InputYourLocal();
            q2.Content = USABoy.InputYourLocal1();
            Login1.Content = USABoy.InputYourLocal2();
            Registry1.Content = USABoy.InputYourLocal3();
            Exit1.Content = USABoy.InputYourLocal4();
            Login1.FontSize = 20;
            Registry1.FontSize = 20;
            Exit1.FontSize = 20;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Client UABoy = new Client(new UA());
            q1.Content = UABoy.InputYourLocal();
            q2.Content = UABoy.InputYourLocal1();
            Login1.Content = UABoy.InputYourLocal2();
            Registry1.Content = UABoy.InputYourLocal3();
            Exit1.Content = UABoy.InputYourLocal4();
            Login1.FontSize = 18;
            Registry1.FontSize = 18;
            Exit1.FontSize = 18;
        }
    }
}
