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
namespace Проект
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

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
            TicketSale a = new TicketSale();
            a.Show();
            this.Close();
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
        private void Login1(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(106, TimeSpan.FromMilliseconds(300));
            login2.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(82, TimeSpan.FromMilliseconds(300));
            login2.BeginAnimation(HeightProperty, a1);
        }
        private void Login3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(95.2, TimeSpan.FromMilliseconds(500));
            login2.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            login2.BeginAnimation(HeightProperty, a1);
        }
        private void Exit2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(90, TimeSpan.FromMilliseconds(300));
            Exit1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(82, TimeSpan.FromMilliseconds(300));
            Exit1.BeginAnimation(HeightProperty, a1);
        }
        private void Exit3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(81.6, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Exit1.BeginAnimation(HeightProperty, a1);
        }
        private void Registry2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(115, TimeSpan.FromMilliseconds(300));
            Registry1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(82, TimeSpan.FromMilliseconds(300));
            Registry1.BeginAnimation(HeightProperty, a1);
        }
        private void Registry3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(116, TimeSpan.FromMilliseconds(500));
            Registry1.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(69, TimeSpan.FromMilliseconds(500));
            Registry1.BeginAnimation(HeightProperty, a1);
        }
    }
}
