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
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                        // подключаемся к базе данных
        SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-NBH5JF2;Trusted_Connection=Yes;DataBase=TEST;");
        sqlConnection.Open();                                           // открываем базу данных
    SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
        sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
        sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
    return dataTable;
    }
}
