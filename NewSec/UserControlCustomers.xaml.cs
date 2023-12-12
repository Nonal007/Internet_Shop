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
using System.Windows.Navigation;
using System.Windows.Media.Animation;
using System.Windows.Threading;


namespace Internet_Shop.NewSec
{
    /// <summary>
    /// Логика взаимодействия для UserControlCustomers.xaml
    /// </summary>
    public partial class UserControlCustomers : UserControl
    {
        public UserControlCustomers()
        {
            InitializeComponent();

        }

        private void Nexus6p_Click(object sender, RoutedEventArgs e)
        {
            Nexus6p nexus6p = new Nexus6p();
            nexus6p.Show();
        }

        private void Nexus5_Click(object sender, RoutedEventArgs e)
        {
            Nexus5 nexus5 = new Nexus5();
            nexus5.Show();
        }

        private void Nexus7_Click (object sender, RoutedEventArgs e)
        {
            Nexus7 nexus7 = new Nexus7();
            nexus7.Show();
        }

        private void Nexus4_Click (object sender, RoutedEventArgs e)
        {
            Nexus4 nexus4 = new Nexus4();
            nexus4.Show();
        }

        private void nexus6pbuy_click (object sender, RoutedEventArgs e)
        {

            nexus6pbuy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                nexus6pbord.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus6pbord.BeginAnimation(OpacityProperty, ll);

            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus6ppic.BeginAnimation(OpacityProperty, da);
            nexus6pborrd.BeginAnimation(OpacityProperty, da);

        }

        private void nexus5buy_click (Object sender, RoutedEventArgs e)
        {
            nexus5buy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                nexus5sell.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus5sell.BeginAnimation(OpacityProperty, ll);

            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus5pic.BeginAnimation(OpacityProperty, da);
            nexus5bord.BeginAnimation(OpacityProperty, da);

        }

        private void nexus7buy_click (Object sender, RoutedEventArgs e)
        {
            nexus7buy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                nexus7sell.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus7sell.BeginAnimation(OpacityProperty, ll);

            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus7pic.BeginAnimation(OpacityProperty, da);
            nexus7bord.BeginAnimation(OpacityProperty, da);

        }

        private void nexus4buy_click (Object sender, RoutedEventArgs e)
        {
            nexus4buy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                nexus4sell.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus4sell.BeginAnimation(OpacityProperty, ll);

            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus4pic.BeginAnimation(OpacityProperty, da);
            nexus4bord.BeginAnimation(OpacityProperty, da);

        }

        private void nexus4buyOUT_click (Object sender, RoutedEventArgs e)
        {
            nexus4buy.IsEnabled = true;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus4pic.BeginAnimation(OpacityProperty, ll);
                nexus4bord.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus4sell.BeginAnimation(OpacityProperty, da);
            //nexus4sell.Visibility = Visibility.Collapsed;


        }

        private void nexus7buyOUT_click (object sender, RoutedEventArgs e)
        {
            nexus7buy.IsEnabled = true;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus7pic.BeginAnimation(OpacityProperty, ll);
                nexus7bord.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus7sell.BeginAnimation(OpacityProperty, da);

        }

        private void nexus5buyOUT_click (object sender, RoutedEventArgs e)
        {
            nexus5buy.IsEnabled = true;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus5pic.BeginAnimation(OpacityProperty, ll);
                nexus5bord.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus5sell.BeginAnimation(OpacityProperty, da);

        }

        private void nexus6pbuyOUT_click (object sender, RoutedEventArgs e)
        {
            nexus6pbuy.IsEnabled = true;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (s, args) =>
            {
                timer.Stop();


                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),

                };
                nexus6ppic.BeginAnimation(OpacityProperty, ll);
                nexus6pborrd.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            nexus6pbord.BeginAnimation(OpacityProperty, da);

        }


    }
}
