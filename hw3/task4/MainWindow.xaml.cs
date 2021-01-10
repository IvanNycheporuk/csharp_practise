using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        int seconds = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            
            dispatcherTimer.Tick += dispatcherTimer_Tick;            
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);

            CustomTime.Content = "00:00:00";
        }

        private void Button_Start(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            seconds = 0;
            CustomTime.Content = "00:00:00";
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            seconds++;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                seconds / 3600, seconds / 60, seconds);
            
            CustomTime.Content = elapsedTime;
        }
    }
}
