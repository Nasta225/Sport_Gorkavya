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

namespace WpfApp1.Sport
{
    /// <summary>
    /// Логика взаимодействия для Tovar.xaml
    /// </summary>
    public partial class Tovar : Window
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void Vorota_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Vorota vorota = new Vorota();
            vorota.Show();
            myWindows.Close();
        }
        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Catalog catalog = new Catalog();
            catalog.Show();
            myWindows.Close();
        }
        private void vorota3_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Vorota3 vorota3 = new Vorota3();
            vorota3.Show();
            myWindows.Close();
        }
        private void vorota2_Click_1(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Vorota1 vorota1xaml = new Vorota1();
            vorota1xaml.Show();
            myWindows.Close();
        }
        private void vorota4_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Vorota2 vorota2 = new Vorota2();
            vorota2.Show();
            myWindows.Close();
        }
        private void Korzina_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
            myWindows.Close();
        }
    }
}
