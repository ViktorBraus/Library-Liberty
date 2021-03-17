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
//using Проект.Classes;
namespace Проект
{
    /// <summary>
    /// Логика взаимодействия для Registry.xaml
    /// </summary>
    public partial class Registry : Window
    {

        //public string _Name, Surname, Phone, Mail, Username, Password;
        //string Password;
        public Registry()
        {
            InitializeComponent();
        }
        public FillBehavior Timespan { get; private set; }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if ((a.Text != "") && (a1.Text != "") && (a2.Text != "")
                && (a3.Text != "") && (a4.Text != "")
                && (a6.Password != "")&&(a7.Password!=""))
            {
                /*
                _Name = a.Text;
                Surname = a1.Text;
                Phone = a2.Text;
                Mail = a3.Text;
                Username = a4.Text;
                Password = a5.Password;*/
                Account account = Account.GetInstance(a.Text, a1.Text, a2.Text, a3.Text, a4.Text, a5.Text, a6.Password); 
                if (a6.Password != a7.Password)
                {
                    MessageBox.Show("Passwords are not the same. retry please.");
                    MessageBox.Show("Паролі не сходяться. Будь ласка, перевірте правильність набору пароля.");
                    a6.Password = null;
                    a7.Password = null;
                }
                else
                {
                    Database_Registry RStart = new Database_Registry(account.Surname, account.Name, account.LastName, account.Address, account.Number, account.NickName, account.Password);
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
                a5.Text = null;
                a6.Password = null;
                a7.Password = null;
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
            Surname.Content = UABoy.InputYourRegistry();
            Name.Content = UABoy.InputYourRegistry1();
            LastName.Content = UABoy.InputYourRegistry2();
            Address.Content = UABoy.InputYourRegistry3();
            Phone_Number.Content = UABoy.InputYourRegistry4();
            Nickname.Content = UABoy.InputYourRegistry5();
            Password.Content = UABoy.InputYourRegistry6();
            repeatPassword.Content = UABoy.InputYourRegistry7();
            Login1.Content = UABoy.InputYourRegistry8();
            Exit1.Content = UABoy.InputYourRegistry9();
            Login1.FontSize = 18;
            Exit1.FontSize = 18;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Client USABoy = new Client(new USA());
            Surname.Content = USABoy.InputYourRegistry();
            Name.Content = USABoy.InputYourRegistry1();
            LastName.Content = USABoy.InputYourRegistry2();
            Address.Content = USABoy.InputYourRegistry3();
            Phone_Number.Content = USABoy.InputYourRegistry4();
            Nickname.Content = USABoy.InputYourRegistry5();
            Password.Content = USABoy.InputYourRegistry6();
            repeatPassword.Content = USABoy.InputYourRegistry7();
            Login1.Content = USABoy.InputYourRegistry8();
            Exit1.Content = USABoy.InputYourRegistry9();
            Login1.FontSize = 20;
            Exit1.FontSize = 20;
        }

    }
}
