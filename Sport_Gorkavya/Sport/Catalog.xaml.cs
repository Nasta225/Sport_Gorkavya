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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        public Catalog()
        {
            InitializeComponent();       
        }

        private void CatalogTovarov_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Tovar tovar = new Tovar();
            tovar.Show();
            myWindows.Close();
        }

        private void Catalog1_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            TovatShoes tovarShose = new TovatShoes();
            tovarShose.Show();
            myWindows.Close();
        }

        private void Tovari_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TablicaTovarov_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Tabliza tabliza = new Tabliza();
            tabliza.Show();
            myWindows.Close();
        }
    }
}
    

