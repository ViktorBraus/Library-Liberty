using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using Проект.Classes;
using Проект.Abstract;

namespace Проект
{
    /// <summary>
    /// Логика взаимодействия для TicketSale.xaml
    /// </summary>
    public partial class UserTicket : Window
    {
        public string _Name, Phone, Mail, Surname, Password, _Username, _Password;
        string connectionString;
        SqlDataAdapter adapter;
        DataTable TicketsOrder;

        public UserTicket()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand comd1 = new SqlCommand("Select distinct  Найменування_жанру from Жанри", connection);
                SqlCommand comd2 = new SqlCommand("Select distinct  Автор from Книги", connection);
                SqlCommand comd3 = new SqlCommand("Select distinct  Назва from Книги", connection);
                SqlCommand comd4 = new SqlCommand("Select distinct  Сума_застави from Книги", connection);
                SqlCommand comd5 = new SqlCommand("Select distinct  Сума_прокату from Книги", connection);

                SqlDataReader DR1 = comd1.ExecuteReader();
                while (DR1.Read())
                {
                    C1.Items.Add(DR1[0]);

                }
                DR1.Close();
                SqlDataReader DR2 = comd2.ExecuteReader();
                while (DR2.Read())
                {
                    C2.Items.Add(DR2[0]);

                }
                DR2.Close();
                SqlDataReader DR3 = comd3.ExecuteReader();
                while (DR3.Read())
                {
                    C3.Items.Add(DR3[0]);

                }
                DR3.Close();
                SqlDataReader DR4 = comd4.ExecuteReader();
                while (DR4.Read())
                {
                    C4.Items.Add(DR4[0]);

                }
                DR4.Close();
                SqlDataReader DR5 = comd5.ExecuteReader();
                while (DR5.Read())
                {
                    C5.Items.Add(DR5[0]);

                }
                DR5.Close();
            }
            //MainWindow a1 = new MainWindow();
            Account account = Account.GetInstance(null, null, null, null, null, null, null);
            UserName.Content = "Вітаємо, " + account.NickName;

        }
        private void customWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        public FillBehavior Timespan { get; private set; }
        private void Login2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(163, TimeSpan.FromMilliseconds(300));
            Login1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(73, TimeSpan.FromMilliseconds(300));
            Login1.BeginAnimation(HeightProperty, a1);
        }
        private void Login3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(158, TimeSpan.FromMilliseconds(500));
            Login1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Login1.BeginAnimation(HeightProperty, a1);
        }
        private void Exit2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(163, TimeSpan.FromMilliseconds(300));
            Exit1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(73, TimeSpan.FromMilliseconds(300));
            Exit1.BeginAnimation(HeightProperty, a1);
        }
        private void C1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand comd6 = new SqlCommand("Select distinct Автор from Книги,Жанри where Найменування_жанру='" + C1.SelectedValue.ToString() + "' and Код_=Код_Жанру", connection);
                SqlDataReader DR6 = comd6.ExecuteReader();
                C2.Items.Clear();
                while (DR6.Read())
                {
                    C2.Items.Add(DR6[0]);
                }
                DR6.Close();
                connection.Close();
            }
        }
        private void C2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (C1.SelectedValue == null)
            {
                MessageBox.Show("Спочатку Оберіть Жанр книги.");
                MessageBox.Show("At first, choose the book jenre.");
                C1.Text = "Жанр";
                C2.Text = "Автор";
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand comd5 = new SqlCommand("Select distinct Назва from Книги,Жанри where Автор ='" + C2.SelectedValue.ToString() + "' and Код_=Код_Жанру", connection);
                    SqlDataReader DR5 = comd5.ExecuteReader();
                    C3.Items.Clear();
                    while (DR5.Read())
                    {

                        C3.Items.Add(DR5[0]);
                    }
                    DR5.Close();
                    connection.Close();
                }
            }
            
        }

        private void C3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (C1.SelectedValue == null)
            {
                MessageBox.Show("Спочатку Оберіть Жанр книги.");
                MessageBox.Show("At first, choose the book jenre.");
                C1.Text = "Жанр";
                C2.Text = "Автор";
                C3.Text = "Назва книги";
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
                {
                    connection.Open();
                    //Select distinct Сума_прокату from Книги,Жанри where Автор ='Джоан Роулінг'and Найменування_жанру='Фентезі'and Назва='Гаррі Поттер і келих вогню';
                    SqlCommand comd5 = new SqlCommand("Select Сума_застави from Книги,Жанри where Назва ='" + C3.SelectedValue.ToString() + "'and Автор ='" + C2.SelectedValue.ToString() + "' and Найменування_жанру='"+C1.SelectedValue.ToString() +"'", connection);
                    SqlDataReader DR5 = comd5.ExecuteReader();
                    C4.Items.Clear();
                    while (DR5.Read())
                    {
                        C4.Items.Add(DR5[0]);
                    }
                    DR5.Close();
                    connection.Close();
                }
            }
        }

        private void C4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (C1.SelectedValue == null)
            {
                MessageBox.Show("Спочатку Оберіть Жанр книги.");
                MessageBox.Show("At first, choose the book jenre.");
                C1.Text = "Жанр";
                C2.Text = "Автор";
                C3.Text = "Назва книги";
                C4.Text = "Сума_застави";
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTOR_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
                {
                    connection.Open();
                    //Select distinct Сума_прокату from Книги,Жанри where Автор ='Джоан Роулінг'and Найменування_жанру='Фентезі'and Назва='Гаррі Поттер і келих вогню';
                    SqlCommand comd5 = new SqlCommand("Select Сума_прокату from Книги,Жанри where Назва ='" + C3.SelectedValue.ToString() + "'and Автор ='" + C2.SelectedValue.ToString() + "' and Найменування_жанру='" + C1.SelectedValue.ToString() + "'", connection);
                    SqlDataReader DR5 = comd5.ExecuteReader();
                    C5.Items.Clear();
                    while (DR5.Read())
                    {
                        C5.Items.Add(DR5[0]);
                    }
                    DR5.Close();
                    connection.Close();
                }
            }
        }

        private void Exit3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(158, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(HeightProperty, a1);
        }

        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(TicketsOrder);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if ((C1.Text != "Жанр книги") && (C2.Text != "Автор") && (C3.Text != "Назва книги")
                && (C4.Text != "Сума застави") && (C5.Text != "Сума прокату"))
            {
                Ticket ticket1 = new DefaultTicket();
                ticket1.Назва_книги = C3.Text;
                ticket1.Жанр_книги = C1.Text;
                ticket1.Автор= C2.Text;
                ticket1.Нікнейм_Читача = UserName.Content.ToString();
                ticket1.Дата_Видачі = DateTime.Now;
                ticket1.Очікувана_Дата_Здачі = DateTime.Now.AddDays(14);
                ticket1.Фактична_Дата_Здачі = new DateTime(); 
                ticket1.Сумма_Штрафів = 0;
                //Account account = Account.GetInstance1(C1.Text, C2.Text, C3.Text, C4.Text, C6.Text, int.Parse(C5.Text), int.Parse(C7.Text));
                //MessageBox.Show(ticket1.From);

                DataBase_Ticket RStart = new DataBase_Ticket(ticket1, UserName.Content.ToString());

                //using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB_BRAUS\SQLEXPRESS01;Initial Catalog=Library;Integrated Security=True"))
                //{
                //    connection.Open();
                //    SqlCommand comd5 = new SqlCommand("Delete from Билет where [Тип Билета]='" + C6.Text + "' and [Цена за билет]='" + ticket1.Price + "'and [Посадочное место]='" + ticket1.Place + "'", connection);
                //    SqlDataReader DR4 = comd5.ExecuteReader();
                //    DR4.Close();
                //    connection.Close();
                //}

                MessageBox.Show("Книга оформлена Успішно.");
                MessageBox.Show("A book was ordered successfully)");
                MainWindow a = new MainWindow();
                a.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Some of fields was not selected. please check all of them.");
                MessageBox.Show("Декотрі з полей не були обрані. Будь ласка, оберіть у кожному з них.");
                C1.Text = "Жанр";
                C2.Text = "Автор";
                C3.Text = "Назва книги";
                C4.Text = "Сума_застави";
                C5.Text = "Сума_прокату";
            }

        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Client UABoy = new Client(new UA());

            Exit1.Content = UABoy.InputYourUTicket7();
            Login1.Content = UABoy.InputYourUTicket8();
            TicketOrder.Content = UABoy.InputYourUTicket9();

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Client USABoy = new Client(new USA());
            Exit1.Content = USABoy.InputYourUTicket7();
            Login1.Content = USABoy.InputYourUTicket8();
            TicketOrder.Content = USABoy.InputYourUTicket9();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
    }
}
