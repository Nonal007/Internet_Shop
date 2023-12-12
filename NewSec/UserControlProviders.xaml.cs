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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Internet_Shop.NewSec
{
    /// <summary>
    /// Логика взаимодействия для UserControlProviders.xaml
    /// </summary>
    public partial class UserControlProviders : UserControl
    {
        public UserControlProviders()
        {
            InitializeComponent();
        }

        private void SamsungA34_click (object sender, RoutedEventArgs e)
        {
            //Samsungs23.Visibility = Visibility.Collapsed;
            SamsungA34 samsunga34 = new SamsungA34();
            samsunga34.Show();
        }
        private void samsungs23_click(object sender, RoutedEventArgs e)
        {
            samsungs23 samsungs23 = new samsungs23();
            samsungs23.Show();
        }

        private void samsungfold_Click (object sender, RoutedEventArgs e)
        {
            samsungflip samsungflip = new samsungflip();
            samsungflip.Show();
        }

        private void samsungflip_Click (object sender, RoutedEventArgs e)
        {
            samsungfold samsungfold = new samsungfold();
            samsungfold.Show();
        }

        private void SamsungA34Buy_click (object sender, RoutedEventArgs e)
        {
            //samsunga34bord.IsEnabled = false;
            //SamsungA34Buy.IsEnabled = false;

            SamsungA34Buy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            // Задать обработчик события для активации анимации после задержки
            timer.Tick += (s, args) =>
            {
                // Остановить таймер
                timer.Stop();


                // Создать и запустить анимацию

                hyyp.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true

                };
                hyyp.BeginAnimation(OpacityProperty, ll);

            };

            // Запустить таймер
            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                //AutoReverse = true
            };
            Image1.BeginAnimation(OpacityProperty, da);
            dddsfdsdf.BeginAnimation(OpacityProperty, da);



            //System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 10);
            //dispatcherTimer.Start();

            //Image image = FindName("Image1") as Image;
            //if (image != null)
            //{
            //    image.Effect = new DropShadowEffect { BlurRadius = 5, Color = Colors.Blue, Direction = 315, Opacity = 4, RenderingBias = RenderingBias.Performance, ShadowDepth = 5 };
            //}

        }

        private void SamsungS23Buy_click (object sender, RoutedEventArgs e)
        {

            SamsungS23Buy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            // Задать обработчик события для активации анимации после задержки
            timer.Tick += (s, args) =>
            {
                // Остановить таймер
                timer.Stop();


                // Создать и запустить анимацию

                samsungs23bron.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true

                };
                samsungs23bron.BeginAnimation(OpacityProperty, ll);

            };

            // Запустить таймер
            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                //AutoReverse = true
            };
            samsungs23pic.BeginAnimation(OpacityProperty, da);
            samsungs23bord.BeginAnimation(OpacityProperty, da);

        }

        private void SamsungZFold_click (object sender, RoutedEventArgs e)
        {

            SamsungZFoldBuy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            // Задать обработчик события для активации анимации после задержки
            timer.Tick += (s, args) =>
            {
                // Остановить таймер
                timer.Stop();


                // Создать и запустить анимацию

                samsungszfoldbron.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true

                };
                samsungszfoldbron.BeginAnimation(OpacityProperty, ll);

            };

            // Запустить таймер
            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                //AutoReverse = true
            };
            samsungzfoldpic.BeginAnimation(OpacityProperty, da);
            samsungzfoldbord.BeginAnimation(OpacityProperty, da);

        }

        private void SamsungZFlipBuy_click (object sender, RoutedEventArgs e)
        {

            SamsungZFlipBuy.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            // Задать обработчик события для активации анимации после задержки
            timer.Tick += (s, args) =>
            {
                // Остановить таймер
                timer.Stop();


                // Создать и запустить анимацию

                samsungzflipbord.Visibility = Visibility.Visible;

                DoubleAnimation ll = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(1)),
                    //AutoReverse = true

                };
                samsungzflipbord.BeginAnimation(OpacityProperty, ll);

            };

            // Запустить таймер
            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                //AutoReverse = true
            };
            //samsungzfoldpic.BeginAnimation(OpacityProperty, da);
            samsungzflipp.BeginAnimation(OpacityProperty, da);

        }
        //private void dispatcherTimer_Tick(object sender, EventArgs e)
        //{
        //    for (int i = 1; i < +100; i++)
        //    {
        //        Image1.Opacity = i;
        //        //Image1.Content = i;
        //    }
        //}


        private void SamsungZFlipBuyOUT_click (object sender, RoutedEventArgs e)
        {
            SamsungZFlipBuy.IsEnabled = true;
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
                samsungzflipp.BeginAnimation(OpacityProperty, ll);
                //nexus5bord.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            samsungzflipbord.BeginAnimation(OpacityProperty, da);

        }

        private void SamsungZFoldBuyOUT_click (Object sender, RoutedEventArgs e)
        {
            SamsungZFoldBuy.IsEnabled = true;
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
                samsungzfoldbord.BeginAnimation(OpacityProperty, ll);
               
                samsungzfoldpic.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            samsungszfoldbron.BeginAnimation(OpacityProperty, da);


        }

        private void Samsungs23BuyOUT_click (object sender, RoutedEventArgs e)
        {
            SamsungS23Buy.IsEnabled = true;
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
                samsungs23bord.BeginAnimation(OpacityProperty, ll);
                samsungs23pic.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            samsungs23bron.BeginAnimation(OpacityProperty, da);

        }

        private void samsunga32BuyOUT_click (object sender, RoutedEventArgs e)
        {
            SamsungA34Buy.IsEnabled = true;
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
                dddsfdsdf.BeginAnimation(OpacityProperty, ll);
                Image1.BeginAnimation(OpacityProperty, ll);


            };

            timer.Start();

            DoubleAnimation da = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
            };
            hyyp.BeginAnimation(OpacityProperty, da);


        }


    }
}
