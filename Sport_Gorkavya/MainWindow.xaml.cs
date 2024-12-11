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
using WpfApp1.Sport;

namespace Sport_Gorkavya
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

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            string Password = PasswordInput.Text.Trim();
            string Admin = "123";
            string Manager = "12345";
            string Client = "1";

            if (Password == Admin)
            {
                btnAdmin.Visibility = Visibility.Visible;
                btnManager.Visibility = Visibility.Collapsed;
                btnClient.Visibility = Visibility.Collapsed;
            }
            else if (Password == Manager)
            {
                btnAdmin.Visibility = Visibility.Collapsed;
                btnManager.Visibility = Visibility.Visible;
                btnClient.Visibility = Visibility.Collapsed;
            }
            else if (Password == Client)
            {
                btnAdmin.Visibility = Visibility.Collapsed;
                btnManager.Visibility = Visibility.Collapsed;
                btnClient.Visibility = Visibility.Visible;
            }
        }

        private void btnManager_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Catalog catalog = new Catalog();
            catalog.Show();
            myWindows.Close();
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Catalog catalog = new Catalog();
            catalog.Show();
            myWindows.Close();
        }

        private void btnClient_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Catalog catalog = new Catalog();
            catalog.Show();
            myWindows.Close();
        }
    }
}
