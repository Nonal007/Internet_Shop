using MaterialDesignThemes.Wpf;
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

namespace Internet_Shop.NewSec
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Nexus", new UserControlCustomers()));
            menuRegister.Add(new SubItem("Samsung", new UserControlProviders()));
            //menuRegister.Add(new SubItem("Employees"));
            //menuRegister.Add(new SubItem("Products"));
            var item6 = new ItemMenu("Телефоны", menuRegister, PackIconKind.Cellphone);


            //var menuSchedule = new List<SubItem>();
            //menuSchedule.Add(new SubItem("Services"));
            //menuSchedule.Add(new SubItem("Meetings"));
            //var item1 = new ItemMenu("Appointments", menuSchedule, PackIconKind.Schedule);

            //var menuReports = new List<SubItem>();
            //menuReports.Add(new SubItem("Customers"));
            //menuReports.Add(new SubItem("Providers"));
            //menuReports.Add(new SubItem("Products"));
            //menuReports.Add(new SubItem("Stock"));
            //menuReports.Add(new SubItem("Sales"));
            //var item2 = new ItemMenu("Reports", menuReports, PackIconKind.FileReport);

            //var menuExpenses = new List<SubItem>();
            //menuExpenses.Add(new SubItem("Fixed"));
            //menuExpenses.Add(new SubItem("Variable"));
            //var item3 = new ItemMenu("Expenses", menuExpenses, PackIconKind.ShoppingBasket);

            //var menuFinancial = new List<SubItem>();
            //menuFinancial.Add(new SubItem("Cash flow"));
            //var item4 = new ItemMenu("Financial", menuFinancial, PackIconKind.ScaleBalance);

            Menu.Children.Add(new UserControlMenuItem(item6, this));
            //Menu.Children.Add(new UserControlMenuItem(item1, this));
            //Menu.Children.Add(new UserControlMenuItem(item2, this));
            //Menu.Children.Add(new UserControlMenuItem(item3, this));
            //Menu.Children.Add(new UserControlMenuItem(item4, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        //Theme Code ========================>
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        //===================================>

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            //Theme Code ========================>
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
                StackPanelMain.Background = Brushes.GhostWhite;
                Grid_color.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#349fda"));
                BorderGrid_color.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#349fda"));
                ImageBack_color.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#349fda"));
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
                StackPanelMain.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF333333"));
                Grid_color.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#015f92"));
                BorderGrid_color.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#015f92"));
                ImageBack_color.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#015f92"));
            }

            paletteHelper.SetTheme(theme);
            //===================================>
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


    }
}
