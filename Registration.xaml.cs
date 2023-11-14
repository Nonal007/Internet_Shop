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

namespace Internet_Shop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Back_button (object sender, RoutedEventArgs e)
        {
            
            MainWindow internet_Shop = new MainWindow();
            internet_Shop.Show();
            this.Close();
        }
        private void Login_button (object sender, RoutedEventArgs e)
        {
            Login internet_shop = new Login();
            internet_shop.Show();
            this.Close();
        }
    }
}
