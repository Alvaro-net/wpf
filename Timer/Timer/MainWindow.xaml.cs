using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            lblTimer.Content = "00:00:00.000";
            DispatcherTimer timer = new DispatcherTimer();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            stopbtn.IsEnabled = false;
            resetbtn.IsEnabled = false;
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    ts.Hours,ts.Minutes, ts.Seconds, ts.Milliseconds );
                lblTimer.Content = currentTime;
            }
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            TimeSpan ts = stopWatch.Elapsed;
            lblTimer.Content = stopWatch.Elapsed;//String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();
            dt.Start();
            startbtn.IsEnabled = false;
            stopbtn.IsEnabled = true;
            resetbtn.IsEnabled = true;
        }

        private void stopbtn_Click(object sender, RoutedEventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
                startbtn.IsEnabled = true;
                stopbtn.IsEnabled = false;
                //resetbtn.IsEnabled = false;
            }

        }

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            sw.Reset();
            lblTimer.Content = "00:00:00.000";
            startbtn.IsEnabled = true;
            stopbtn.IsEnabled = false;
            resetbtn.IsEnabled = false;
        }
    }
}
