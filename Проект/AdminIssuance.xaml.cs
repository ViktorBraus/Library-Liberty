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
    /// Логика взаимодействия для AdminIssuance.xaml
    /// </summary>
    public partial class AdminIssuance : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable Readers;
        public AdminIssuance()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            IssuanceTable.RowEditEnding += tickets_RowEditEnding;
        }
        private void tickets_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            UpdateDB();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Видача_Книг";
            Readers = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertPhone1", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Код_Книги", SqlDbType.Int, 4, "Назва"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Код_Читача", SqlDbType.Int, 4, "Автор"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Дата_Видачі", SqlDbType.Date, 10, "Код_Жанру"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Очікувана_Дата_Видачі", SqlDbType.Date, 10, "Сума_застави"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Фактична_Дата_Видачі", SqlDbType.Date, 10, "сума_прокату"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Сумма_Штрафів", SqlDbType.Money, 10, "сума_прокату"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Код", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(Readers);
                IssuanceTable.ItemsSource = Readers.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(Readers);
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (IssuanceTable.SelectedItems != null)
            {
                for (int i = 0; i < IssuanceTable.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = IssuanceTable.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void customWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        public FillBehavior Timespan { get; private set; }
        private void Login2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(179, TimeSpan.FromMilliseconds(300));
            UpdateButton.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(67, TimeSpan.FromMilliseconds(300));
            UpdateButton.BeginAnimation(HeightProperty, a1);
        }
        private void Login3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(176, TimeSpan.FromMilliseconds(500));
            UpdateButton.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(64, TimeSpan.FromMilliseconds(500));
            UpdateButton.BeginAnimation(HeightProperty, a1);
        }
        private void Exit2(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(179, TimeSpan.FromMilliseconds(300));
            DeleteButton.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(67, TimeSpan.FromMilliseconds(300));
            DeleteButton.BeginAnimation(HeightProperty, a1);
        }
        private void Exit3(object sender, EventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation(176, TimeSpan.FromMilliseconds(500));
            DeleteButton.BeginAnimation(WidthProperty, a);
            DoubleAnimation a1 = new DoubleAnimation(64, TimeSpan.FromMilliseconds(500));
            DeleteButton.BeginAnimation(HeightProperty, a1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Client UABoy = new Client(new UA());
            
            readerstable.Content = UABoy.InputYourTicket9();
            booksstable.Content = UABoy.InputYourTicket10();
            bookissuancetable.Content = UABoy.InputYourTicket11();
            DeleteButton.Content = UABoy.InputYourTicket7();
            UpdateButton.Content = UABoy.InputYourTicket8();
            Exit1.Content = UABoy.InputYourRegistry9();
            // UpdateButton.FontSize = 18;
            //  DeleteButton.FontSize = 18;

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Client USABoy = new Client(new USA());
            
            DeleteButton.Content = USABoy.InputYourTicket7();
            UpdateButton.Content = USABoy.InputYourTicket8();
            readerstable.Content = USABoy.InputYourTicket9();
            booksstable.Content = USABoy.InputYourTicket10();
            bookissuancetable.Content = USABoy.InputYourTicket11();
            bookissuancetable.FontSize = 15;
            Exit1.Content = USABoy.InputYourRegistry9();
            // UpdateButton.FontSize = 18;
            //  DeleteButton.FontSize = 18;
        }

        private void readerstable_Click(object sender, RoutedEventArgs e)
        {
            TicketSale a = new TicketSale();
            a.Show();
            this.Close();
        }

        private void booksstable_Click(object sender, RoutedEventArgs e)
        {
            AdminBooksTable a = new AdminBooksTable();
            a.Show();
            this.Close();
        }

        private void bookissuancetable_Click(object sender, RoutedEventArgs e)
        {
            AdminIssuance a = new AdminIssuance();
            a.Show();
            this.Close();
        }
    }
}
