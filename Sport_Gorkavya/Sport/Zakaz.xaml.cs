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
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Window
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Camovyzov_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new Adres());
        }

        private void DostavkaPoAgresy_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new Samo());
        }

        private void Podrobnee_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Shose1 shose1 = new Shose1();
            shose1.Show();
            myWindows.Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Oplata1 oplata1 = new Oplata1();
            oplata1.Show();
            myWindows.Close();
        }
    }
}
