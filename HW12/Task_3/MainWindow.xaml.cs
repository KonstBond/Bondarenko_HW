using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
            InitializedTimer();
        }

        private void InitializedTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(1);
            timer.Start();
            timer.IsEnabled = false;
            timer.Tick += Timer_Tick;
        }

        public event EventHandler Run = null;
        public event EventHandler ChangeValueUP = null;
        public event EventHandler ChangeValueDOWN = null;

        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = true;    
        }

        private void ValueUP_Click(object sender, RoutedEventArgs e)
        {
            ChangeValueUP.Invoke(sender, e);
        }

        private void ValueDOWN_Click(object sender, RoutedEventArgs e)
        {
            ChangeValueDOWN.Invoke(sender, e);
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (lblTime.Content.ToString() == "00:00:00")
                timer.IsEnabled = false;
            else
                Run.Invoke(sender, e);
        }
    }
}
