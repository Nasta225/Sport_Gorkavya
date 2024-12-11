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
    /// Логика взаимодействия для Vorota3.xaml
    /// </summary>
    public partial class Vorota3 : Window
    {
        public Vorota3()
        {
            InitializeComponent();
        }

        private void Strelka_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            Tovar tovar = new Tovar();
            tovar.Show();
            myWindows.Close();
        }
    }
}
