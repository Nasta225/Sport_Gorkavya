using Sport_Gorkavya.ApplicationData;
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

namespace Sport_Gorkavya.Sport
{
    /// <summary>
    /// Логика взаимодействия для TablicaAdd.xaml
    /// </summary>
    public partial class TablicaAdd : Window
    {
        private SportTovar _currenttovar = new SportTovar();
        public TablicaAdd(SportTovar selectedtovar)
        {
            InitializeComponent();
            if (selectedtovar != null)
                _currenttovar = selectedtovar;

            DataContext = _currenttovar;
            ComboStatus.ItemsSource = SportEntities.GetContext().Status.ToList();
            ComboDostavka.ItemsSource = SportEntities.GetContext().Dostavka.ToList();
            ComboPynk.ItemsSource = SportEntities.GetContext().Pynkt.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currenttovar.naimenov))
                errors.AppendLine("Укажите название товара");
            if (_currenttovar.kolichestvo <= 0)
                errors.AppendLine("Количество товара не можеть быть больше или ровно 0");
            if (_currenttovar.cena <= 0)
                errors.AppendLine("Количество товара не можеть быть меньше или ровно 0");
            if (_currenttovar.brend == null)
                errors.AppendLine("Количество товара не можеть быть меньше или ровно 0");
            if (_currenttovar.PazmerObuvi == null)
                errors.AppendLine("Количество товара не можеть быть меньше или ровно 0");
            if (_currenttovar.Dostavka == null)
                errors.AppendLine("Выберете Выберите доставку");
            if (_currenttovar.Pynkt == null)
                errors.AppendLine("Выберете пунтк");
            if (_currenttovar.Status == null)
                errors.AppendLine("Выберете статус");
            
           
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            //Добавление
            if (_currenttovar.id == 0)
                SportEntities.GetContext().SportTovar.Add(_currenttovar);

            try
            {
                SportEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
