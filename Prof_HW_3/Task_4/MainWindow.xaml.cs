using System;
using System.IO;
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
using System.IO.IsolatedStorage;

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CP_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            lbl.Content = CP.SelectedColorText;
            BrushConverter BC = new BrushConverter();
            lbl.Background = (Brush)BC.ConvertFromString(CP.SelectedColorText);
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream FS = new IsolatedStorageFileStream("Info.txt", FileMode.OpenOrCreate, FileAccess.Write, file);
            StreamWriter SW = new StreamWriter(FS);

            SW.WriteLine($"{lbl.Content}\n{lbl.Background}");

            SW.Close();
            FS.Close();
        }

        private void Wind_Loaded(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForAssembly();
            if (file.FileExists("Info.txt"))
            {
                IsolatedStorageFileStream FS = new IsolatedStorageFileStream("Info.txt", FileMode.Open, FileAccess.Read, file);
                StreamReader SR = new StreamReader(FS);

                string[] s = SR.ReadToEnd().Split('\n');
                BrushConverter BC = new BrushConverter();

                lbl.Content = s[0];
                lbl.Background = (Brush)BC.ConvertFromString(s[1]);

                SR.Close();
                FS.Close();
            }
        }
    }
}
