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
            string AdminPassword = "Админ";
            string ManagerPassword = "Менеджер";
            string ClientPassword = "Клиент";

            string AdminLogin = "111";
            string ManagerLogin = "222";
            string ClientLogin = "333";

            if (PasswordInput.Text == AdminPassword && LoginInput.Text == AdminLogin)
            {
                btnAdmin.Visibility = Visibility.Visible;
                btnManager.Visibility = Visibility.Collapsed;
                btnClient.Visibility = Visibility.Collapsed;    
            }
            else if (PasswordInput.Text == ManagerPassword && LoginInput.Text == ManagerLogin)
            {
                btnAdmin.Visibility = Visibility.Collapsed;
                btnManager.Visibility = Visibility.Visible;
                btnClient.Visibility = Visibility.Collapsed;
            }
            else if (PasswordInput.Text == ClientPassword && LoginInput.Text == ClientLogin)
            {
                btnAdmin.Visibility = Visibility.Collapsed;
                btnManager.Visibility = Visibility.Collapsed;
                btnClient.Visibility = Visibility.Visible;
            }       
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void btnManager_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.ShowTablicaTovarov();
            catalog.Show();
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.ShowTablicaTovarov();
            catalog.Show();
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
