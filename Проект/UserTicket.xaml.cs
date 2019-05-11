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
            using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand comd1 = new SqlCommand("Select distinct  [Город Отправления] from Билет", connection);
                SqlCommand comd2 = new SqlCommand("Select distinct  [Город Прибытия] from Билет", connection);
                SqlCommand comd3 = new SqlCommand("Select distinct  [Дата Отправления] from Билет", connection);
                SqlCommand comd4 = new SqlCommand("Select distinct  [Дата Прибытия] from Билет", connection);
                SqlCommand comd5 = new SqlCommand("Select distinct  [Цена за билет] from Билет", connection);
                SqlCommand comd6 = new SqlCommand("Select distinct  [Тип Билета] from Билет", connection);
                SqlCommand comd7 = new SqlCommand("Select distinct  [Посадочное Место] from Билет", connection);
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
                SqlDataReader DR6 = comd6.ExecuteReader();
                while (DR6.Read())
                {
                    C6.Items.Add(DR6[0]);

                }
                DR6.Close();
                SqlDataReader DR7 = comd7.ExecuteReader(); 
                while (DR7.Read())
                {
                    C7.Items.Add(DR7[0]);
                }
                DR7.Close();
                connection.Close();
            }
            MainWindow a1 = new MainWindow();
            Account account = Account.GetInstance(null,null,null,null,null,null);
            UserName.Content = account.Login;

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
    
        private void C6_SelectionChanged(object sender, EventArgs e)
        {
            if (C6.Text!="Тип Квитка" || C6.SelectedValue.ToString() != null)
            {
                if (C6.SelectedValue.ToString() != "Тип Квитка")
                {
                    string s = C6.SelectedValue.ToString();
                    using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
                    {
                        connection.Open();//"Select Count (*) From Регистрация where Username = '" + _username + "'"
                        SqlCommand comd5 = new SqlCommand("Select distinct [Цена за билет] from Билет where [Тип Билета]='" + s + "'", connection);
                        SqlCommand comd4 = new SqlCommand("Select distinct [Цена за билет] from Билет ", connection);
                        if (s == "Эконом")
                        {
                            SqlDataReader DR5 = comd5.ExecuteReader();
                            while (DR5.Read())
                            {

                                C5.Items.Add(DR5[0]);

                            }
                            DR5.Close();
                            SqlDataReader DR4 = comd4.ExecuteReader();
                            while (DR4.Read())
                            {

                                C5.Items.Remove(DR4[0]);
                            }
                            DR4.Close();
                            

                        }
                        else if (s == "Бизнес")
                        {
                            SqlDataReader DR4 = comd4.ExecuteReader();
                            while (DR4.Read())
                            {

                                C5.Items.Remove(DR4[0]);
                            }
                            DR4.Close();
                            SqlDataReader DR6 = comd5.ExecuteReader();
                            while (DR6.Read())
                            {

                                C5.Items.Add(DR6[0]);

                            }

                            DR6.Close();

                        }
                        else if (s == "Первый")
                        {
                            SqlDataReader DR4 = comd4.ExecuteReader();
                            while (DR4.Read())
                            {

                                C5.Items.Remove(DR4[0]);
                            }
                            DR4.Close();
                            SqlDataReader DR7 = comd5.ExecuteReader();
                            while (DR7.Read())
                            {

                                C5.Items.Add(DR7[0]);

                            }

                            DR7.Close();

                        }
                        connection.Close();
                    }
                }
                else if (C6.SelectedValue.ToString() == null)
                {
                    C6.SelectedValue = "Тип Квитка";
                }
            }
        }
        /*private void C5_SelectionChanged(object sender, EventArgs e)
        {
            if (C6.Text == "Тип Квитка")
            {
                MessageBox.Show("Спочатку Оберіть тип квитка.");
                MessageBox.Show("At first, choose the type of ticket.");
               
                C5.Text = "Ціна за квиток";
            }
            /*if (C5.Text != "Ціна за квиток" || C5.SelectedValue.ToString() != null)
            {
                if (C5.SelectedValue.ToString() != "Ціна за квиток")
                {
                    string s = C5.SelectedValue.ToString();
                    using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
                    {
                        connection.Open();//"Select Count (*) From Регистрация where Username = '" + _username + "'"
                        SqlCommand comd5 = new SqlCommand("Select distinct [Тип Билета] from Билет where [Цена за билет]='" + s + "'", connection);
                        SqlCommand comd4 = new SqlCommand("Select distinct [Тип Билета] from Билет ", connection);
                        if (s == "1000" || s == "1200")
                        {
                            SqlDataReader DR4 = comd4.ExecuteReader();
                            while (DR4.Read())
                            {

                                C6.Items.Remove(DR4[0]);
                            }
                            DR4.Close();
                            SqlDataReader DR5 = comd5.ExecuteReader();
                            while (DR5.Read())
                            {

                                C6.Items.Add(DR5[0]);

                            }
                            DR5.Close();

                        }
                        else if (s == "1500")
                        {
                            SqlDataReader DR4 = comd4.ExecuteReader();
                            while (DR4.Read())
                            {

                                C6.Items.Remove(DR4[0]);
                            }
                            DR4.Close();
                            SqlDataReader DR6 = comd5.ExecuteReader();
                            while (DR6.Read())
                            {

                                C6.Items.Add(DR6[0]);

                            }

                            DR6.Close();

                        }
                        else if (s == "2000")
                        {
                            SqlDataReader DR4 = comd4.ExecuteReader();
                            while (DR4.Read())
                            {

                                C6.Items.Remove(DR4[0]);
                            }
                            DR4.Close();
                            SqlDataReader DR7 = comd5.ExecuteReader();
                            while (DR7.Read())
                            {

                                C6.Items.Add(DR7[0]);

                            }

                            DR7.Close();

                        }
                        connection.Close();
                    }
                }
                else if (C5.SelectedValue.ToString() == null)
                {
                    C5.SelectedValue = "Ціна за квиток";
                }
            }
        }*/
       
       private void C5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (C6.Text == "Тип Квитка" || C6.SelectedValue==null)
            {
                MessageBox.Show("Спочатку Оберіть тип квитка.");
                MessageBox.Show("At first, choose the type of ticket.");
                C5.SelectedValue = "Ціна за квиток";
                C5.SelectedValue = "Ціна за квиток";
                C5.Text = "Ціна за квиток";
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((C1.Text != "Місто Відправлення") && (C2.Text != "Місто Прибуття") && (C3.Text != "Дата Відправлення")
                && (C4.Text != "Дата Прибуття") && (C5.Text != "Ціна за квиток")
                && (C6.Text != "Тип Квитка")&& (C7.Text != "Посадкове місце"))
            {
                Account account = Account.GetInstance1(C1.Text,C2.Text,C3.Text,C4.Text,C6.Text,int.Parse(C5.Text), C7.Text);
                DataBase_Ticket RStart = new DataBase_Ticket(C1.Text, C2.Text, C3.Text, C4.Text, C6.Text, int.Parse(C5.Text), C7.Text, account.Login);
                using (SqlConnection connection = new SqlConnection(@"Data Source=VIKTORB\SQLEXPRESS;Initial Catalog=Braus Airways;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand comd5 = new SqlCommand("Delete from Билет where [Посадочное Место]='"  + C7.Text + "and [Цена за билет]='"+C5.Text+"'", connection);
                    connection.Close();
                }
                
                    MessageBox.Show("Білет Куплено.");
                MessageBox.Show("A ticket was buyed successfully)");
            }
            else
            {
                MessageBox.Show("Some of fields was not selected. please check all of them.");
                MessageBox.Show("Декотрі з полей не були обрані. Будь ласка, оберіть у кожному з них.");
                C1.Text = "Місто Відправлення";
                C2.Text = "Місто Прибуття";
                C3.Text = "Дата Відправлення";
                C4.Text = "Дата Прибуття";
                C5.Text = "Ціна за квиток";
                C6.Text = "Тип Квитка";
                C7.Text = "Посадкове місце";
            }
            
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

         private void Button_Click_1(object sender, RoutedEventArgs e)
         {
             Client UABoy = new Client(new UA());
            C1.Text = UABoy.InputYourUTicket();
            C2.Text = UABoy.InputYourUTicket1();
            C3.Text = UABoy.InputYourUTicket2();
            C4.Text = UABoy.InputYourUTicket3();
            C5.Text = UABoy.InputYourUTicket4();
            C6.Text = UABoy.InputYourUTicket5();
            C7.Text = UABoy.InputYourUTicket6();
            Exit1.Content = UABoy.InputYourUTicket7();
            Login1.Content = UABoy.InputYourUTicket8();
            TicketOrder.Content =UABoy.InputYourUTicket9();

            // UpdateButton.FontSize = 18;
            //  DeleteButton.FontSize = 18;

        }
         private void Button_Click_3(object sender, RoutedEventArgs e)
         {
             Client USABoy = new Client(new USA());
            C1.Text = USABoy.InputYourUTicket();
            C2.Text = USABoy.InputYourUTicket1();
            C3.Text = USABoy.InputYourUTicket2();
            C4.Text = USABoy.InputYourUTicket3();
            C5.Text = USABoy.InputYourUTicket4();
            C6.Text = USABoy.InputYourUTicket5();
            C7.Text = USABoy.InputYourUTicket6();
            Exit1.Content = USABoy.InputYourUTicket7();
            Login1.Content = USABoy.InputYourUTicket8();
            TicketOrder.Content = USABoy.InputYourUTicket9();
            // UpdateButton.FontSize = 18;
            //  DeleteButton.FontSize = 18;
        }

    }
}
