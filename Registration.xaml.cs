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
//using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Controls.Primitives;

namespace Internet_Shop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        readonly string connectionString;
        SqlDataAdapter adapter;
        DataTable UserAndPass;


        public Registration()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Internet_Shop"].ConnectionString;
        }
        private void Back_button (object sender, RoutedEventArgs e)
        {



            MainWindow internet_Shop = new MainWindow();
            internet_Shop.Show();
            this.Close();
        }


        //Регистрация
        private void CreateAdapter(SqlConnection connection)
        {
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand("sp_Select", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.InsertCommand = new SqlCommand("sp_Registartion", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@newUser", SqlDbType.NChar, 10, "user_name"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@newPass", SqlDbType.NChar, 10, "user_password"));
            SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@id_user", SqlDbType.Int, 0, "id");
            parameter.Direction = ParameterDirection.Output;
        }


        //Обновление базы
        private void UpdateDB()
        {
            adapter.Update(UserAndPass);
        }

        private void Login_button (object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            //Form1 newForm = new Form1();
            //newForm.Show();
        }

        private void Registartion_button_click (object sender, RoutedEventArgs e)
        {
            if (textBox_login.Text.Length > 0 & password.Text.Length > 0)
            {
                try
                {
                    UserAndPass.Rows.Add(0, textBox_login.Text, password.Text);
                    adapter.InsertCommand.Parameters["@newUser"].Value = textBox_login.Text;
                    adapter.InsertCommand.Parameters["@newPass"].Value = password.Text;
                    UpdateDB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Login registration = new Login();
                registration.Show();
            }

        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                CreateAdapter(connection);
                UserAndPass = new DataTable();
                adapter.Fill(UserAndPass);
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


        //public DataTable ConnectDB(string selectSQL)
        //{
        //    DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
        //                                                                    // подключаемся к базе данных
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    sqlConnection.Open();                                           // открываем базу данных
        //    SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
        //    sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
        //    sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
        //    return dataTable;
        //}

    }
}
