using Sport_Gorkavya.ApplicationData;
using Sport_Gorkavya.Sport;
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
    /// Логика взаимодействия для Tabliza.xaml
    /// </summary>
    public partial class Tabliza : Window
    {
        public Tabliza()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = SportEntities.GetContext().SportTovar.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            TablicaAdd tablicaAdd = new TablicaAdd(null);
            tablicaAdd.Show();
            myWindows.Close();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var tovarForRemoving = DtGridTovar.SelectedItems.Cast<SportTovar>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить текущее {tovarForRemoving.Count()} Элементов", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    SportEntities.GetContext().SportTovar.RemoveRange(tovarForRemoving);
                    SportEntities.GetContext().SaveChanges();

                    DtGridTovar.ItemsSource = SportEntities.GetContext().SportTovar.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            TablicaAdd tablicaAdd = new TablicaAdd ((sender as Button).DataContext as SportTovar);
            tablicaAdd.Show();
            myWindows.Close();
        }
    }
}
