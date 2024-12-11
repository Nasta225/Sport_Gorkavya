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
    /// Логика взаимодействия для TovatShoes.xaml
    /// </summary>
    public partial class TovatShoes : Window
    {
        public TovatShoes()
        {
            InitializeComponent();
        }
        private void Strelka_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Catalog catalog = new Catalog();
            catalog.Show();
            myWindows.Close();
        }
        private void Sneakers4_Click_1(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Shose1 shose1= new Shose1();
            shose1.Show();
            myWindows.Close();
        }
        private void Sneakers1_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Shose1 shose1 = new Shose1();
            shose1.Show();
            myWindows.Close();
        }
        private void Sneakers2_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Shose2 shose2 = new Shose2();
            shose2.Show();
            myWindows.Close();
        }
        private void Sneakers3_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Shose4 shose4 = new Shose4();
            shose4.Show();
            myWindows.Close();
        }
        private void Sneakers4_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Shose4 shose4 = new Shose4();
            shose4.Show();
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
