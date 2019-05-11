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
using Проект.Classes;
using System.Data;
using System.Data.SqlClient;
using Проект.Classes;
namespace Проект
{
    /// <summary>
    /// Логика взаимодействия для Registry.xaml
    /// </summary>
    public partial class Registry : Window
    {

        //public string _Name, Surname, Phone, Mail, Username, Password;
        string Password;
        public Registry()
        {
            InitializeComponent();
        }
        public FillBehavior Timespan { get; private set; }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if ((a.Text != "") && (a1.Text != "") && (a2.Text != "")
                && (a3.Text != "") && (a4.Text != "")
                && (a5.Password != "")&&(a6.Password!=""))
            {
                /*
                _Name = a.Text;
                Surname = a1.Text;
                Phone = a2.Text;
                Mail = a3.Text;
                Username = a4.Text;
                Password = a5.Password;*/
                Account account = Account.GetInstance(a.Text,a1.Text,a2.Text,a3.Text,a4.Text,a5.Password); 
                if (a5.Password != a6.Password)
                {
                    MessageBox.Show("Passwords are not the same. retry please.");
                    MessageBox.Show("Паролі не сходяться. Будь ласка, перевірте правильність набору пароля.");
                    a5.Password = null;
                    a6.Password = null;
                }
                else
                {
                    Database_Registry RStart = new Database_Registry(account.Name, account.Surname, account.Number, account.Email, account.Login, account.Password);
                    MessageBox.Show("Registration was Done Successfully");
                    MainWindow w = new MainWindow();
                    w.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Some of fields was not written. please check all of them.");
                MessageBox.Show("Декотрі з полей порожні. Будь ласка, заповніть кожне з них.");
                a.Text = null;
                a1.Text = null;
                a2.Text = null;
                a3.Text = null;
                a4.Text = null;
                a5.Password = null;
                a6.Password = null;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
        private void customWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void Login2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(163, TimeSpan.FromMilliseconds(300));
            Login1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(76, TimeSpan.FromMilliseconds(300));
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
            DoubleAnimation a1 = new DoubleAnimation(76, TimeSpan.FromMilliseconds(300));
            Exit1.BeginAnimation(HeightProperty, a1);
        }
        private void Exit3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(158, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(HeightProperty, a1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Client UABoy = new Client(new UA());
            _q1.Content = UABoy.InputYourRegistry();
            _q2.Content = UABoy.InputYourRegistry1();
            _q3.Content = UABoy.InputYourRegistry2();
            _q4.Content = UABoy.InputYourRegistry3();
            _q5.Content = UABoy.InputYourRegistry4();
            _q6.Content = UABoy.InputYourRegistry5();
            _q7.Content = UABoy.InputYourRegistry6();
            Login1.Content = UABoy.InputYourRegistry8();
            Exit1.Content = UABoy.InputYourRegistry7();
            Login1.FontSize = 18;
            Exit1.FontSize = 18;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Client USABoy = new Client(new USA());
            _q1.Content = USABoy.InputYourRegistry();
            _q2.Content = USABoy.InputYourRegistry1();
            _q3.Content = USABoy.InputYourRegistry2();
            _q4.Content = USABoy.InputYourRegistry3();
            _q5.Content = USABoy.InputYourRegistry4();
            _q6.Content = USABoy.InputYourRegistry5();
            _q7.Content = USABoy.InputYourRegistry6();
            Login1.Content = USABoy.InputYourRegistry8();
            Exit1.Content = USABoy.InputYourRegistry7();
            Login1.FontSize = 20;
            Exit1.FontSize = 20;
        }

    }
}
