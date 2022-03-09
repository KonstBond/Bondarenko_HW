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
using System.Configuration;
using System.Xml;
using Microsoft.Win32;


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

        private void CP_FG_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            BrushConverter BC = new BrushConverter();
            Lbl.Foreground = (Brush)BC.ConvertFromString(CP_FG.SelectedColor.ToString());
        }

        private void CP_BG_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            BrushConverter BC = new BrushConverter();
            MainWind.Background = (Brush)BC.ConvertFromString(CP_BG.SelectedColor.ToString());
        }

        private void Btn_Bolt_Click(object sender, RoutedEventArgs e)
        {
            if (Lbl.FontWeight == FontWeights.Bold)
                Lbl.FontWeight = FontWeights.Normal;
            else
                Lbl.FontWeight = FontWeights.Bold;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Lbl.FontStyle == FontStyles.Italic)
                Lbl.FontStyle = FontStyles.Normal;
            else
                Lbl.FontStyle = FontStyles.Italic;
        }

        private void Btn_UP_Click(object sender, RoutedEventArgs e)
        {
            if (Lbl.FontSize < 135)
                Lbl.FontSize = ++Lbl.FontSize;
        }

        private void Btn_Down_Click(object sender, RoutedEventArgs e)
        {
            if (Lbl.FontSize > 1)
                Lbl.FontSize = --Lbl.FontSize;
        }

        private void ListBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            int index = listbox.SelectedValue.ToString().IndexOf(':');
            Lbl.FontFamily = new FontFamily(listbox.SelectedValue.ToString().Substring(index + 2));
        }

        string _path = @"C:\Users\admin\Desktop\ITVDN\HW_C#_Basic\Prof_HW_5\Task_4\App.config";
        XmlDocument _document = new XmlDocument();
        private void saveConfig_Click(object sender, RoutedEventArgs e)
        {
            _document.Load(_path);

            XmlElement root = _document.DocumentElement;

            if (!(root is null))
            {
                var node = root.ChildNodes[1].ChildNodes;

                node[0].Attributes["value"].Value = MainWind.Background.ToString();
                node[1].Attributes["value"].Value = Lbl.Foreground.ToString();
                node[2].Attributes["value"].Value = Lbl.FontStyle.ToString();
                node[3].Attributes["value"].Value = Lbl.FontWeight.ToString();
                node[4].Attributes["value"].Value = Lbl.FontFamily.ToString();
                node[5].Attributes["value"].Value = Lbl.FontSize.ToString();
            }

            _document.Save(_path);
        }

        private void MainWind_Loaded(object sender, RoutedEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\DataFromTask_4");
            if (key != null)
            {

                BrushConverter BC = new BrushConverter();
                MainWind.Background = BC.ConvertFromString(key.GetValue("Background").ToString()) as Brush;
                Lbl.Foreground = BC.ConvertFromString(key.GetValue("Foreground").ToString()) as Brush;

                FontStyleConverter FSC = new FontStyleConverter();
                Lbl.FontStyle = (FontStyle)FSC.ConvertFromString(key.GetValue("FontStyle").ToString());
                FontWeightConverter FWC = new FontWeightConverter();
                Lbl.FontWeight = (FontWeight)FWC.ConvertFromString(key.GetValue("FontWeight").ToString());

                FontFamilyConverter FMC = new FontFamilyConverter();
                Lbl.FontFamily = (FontFamily)FMC.ConvertFromString(key.GetValue("FontFamily").ToString());
                Lbl.FontSize = int.Parse(key.GetValue("FontSize").ToString());
                key.Close();
            }
            else
            {
                _document.Load(_path);

                XmlElement root = _document.DocumentElement;

                if (!(root is null))
                {
                    var node = root.ChildNodes[1].ChildNodes;

                    BrushConverter BC = new BrushConverter();
                    MainWind.Background = BC.ConvertFromString(node[0].Attributes["value"].Value) as Brush;
                    Lbl.Foreground = BC.ConvertFromString(node[1].Attributes["value"].Value) as Brush;

                    FontStyleConverter FSC = new FontStyleConverter();
                    Lbl.FontStyle = (FontStyle)FSC.ConvertFromString(node[2].Attributes["value"].Value);
                    FontWeightConverter FWC = new FontWeightConverter();
                    Lbl.FontWeight = (FontWeight)FWC.ConvertFromString(node[3].Attributes["value"].Value);

                    FontFamilyConverter FMC = new FontFamilyConverter();
                    Lbl.FontFamily = (FontFamily)FMC.ConvertFromString(node[4].Attributes["value"].Value);
                    Lbl.FontSize = int.Parse(node[5].Attributes["value"].Value);
                }
            }
        }

        //Заходить только с правами администратора 
        private void saveRegistry_Click(object sender, RoutedEventArgs e)
        {
            RegistryKey rootKey = Registry.CurrentUser;
            RegistryKey SOFTWAREkey = rootKey.OpenSubKey("Software", true);
            using (RegistryKey newKey = SOFTWAREkey.CreateSubKey("DataFromTask_4"))
            {
                newKey.SetValue("Background", MainWind.Background.ToString());
                newKey.SetValue("Foreground", Lbl.Foreground.ToString());
                newKey.SetValue("FontStyle", Lbl.FontStyle.ToString());
                newKey.SetValue("FontWeight", Lbl.FontWeight.ToString());
                newKey.SetValue("FontFamily", Lbl.FontFamily.ToString());
                newKey.SetValue("FontSize", Lbl.FontSize.ToString());
            }
            SOFTWAREkey.Close();
            rootKey.Close();
        }
    }
}
