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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Internet_Shop
{

    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class NewLogin : Window
    {
        string connectionString;
        SqlDataAdapter adapter;

        public NewLogin()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Internet_Shop"].ConnectionString;
        }

        //Кнопка входа
        private void Login_buttonclick(object sender, RoutedEventArgs e)
        {
            if (autorization(textBox_login.Text, password.Text))
            {
                OpenMainWindow();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        public bool autorization(string user_name, string user_password)
        {
            //if(user_name.Length < 11)
            //{
            //    MessageBox.Show("Логин не может быть менее 11 символов");
            //    return false;
            //}
            DataTable dataTable = new DataTable();
            adapter.SelectCommand.Parameters["@username"].Value = user_name;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            if (dataTable.Rows[0]["user_password"].ToString().Trim() == user_password.Trim())
            {
                return true;
            }

            return false;
        }

        private void Back_button (object sender, RoutedEventArgs e)
        {
            NewRegistartion newregistartion = new NewRegistartion();
            newregistartion.Show();
            this.Close();
        }

        private void CloseWindow_click (object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void OpenMainWindow()
        {
            NewSec.MainWindow MainWindow = new NewSec.MainWindow();
            MainWindow.Show();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("sp_user", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NChar, 20));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }

}
