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
using System.Reflection;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Assembly assembly;
        Type? classTemp;
        public MainWindow()
        {
            InitializeComponent();
            assembly = Assembly.Load("Task_2_Lib");
            classTemp = assembly.GetType("Task_2_Lib.Temperature");
        }

        private void Cels_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object temp = Activator.CreateInstance(classTemp, double.Parse(TBInput.Text));
                MethodInfo? methodCelc = classTemp.GetMethod("ShowTempCelc");
                lblOutput.Content = methodCelc.Invoke(temp, null);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void Kelv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object temp = Activator.CreateInstance(classTemp, double.Parse(TBInput.Text));
                MethodInfo? methodKelv = classTemp.GetMethod("ShowTempKelv");
                lblOutput.Content = methodKelv.Invoke(temp, null);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void Far_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object temp = Activator.CreateInstance(classTemp, double.Parse(TBInput.Text));
                MethodInfo? methodCelc = classTemp.GetMethod("ShowTempFar");
                lblOutput.Content = methodCelc.Invoke(temp, null);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }
    }
}
