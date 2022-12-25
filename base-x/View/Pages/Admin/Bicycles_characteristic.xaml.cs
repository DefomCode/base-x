using base_x.Core;
using base_x.Model;
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

namespace base_x.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Bicycles_characteristic.xaml
    /// </summary>
    public partial class Bicycles_characteristic : Page
    {
        public Bicycles_characteristic()
        {
            InitializeComponent();

            GridBicycles_characteristic.ItemsSource = FrameNavigate.DB.Bicycles_characteristic.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string idBicycles_characteristic = (GridBicycles_characteristic.SelectedItem as Model.Bicycles_characteristic).Model;
            var result = MessageBox.Show("Хотите удалить характеристики велосипеда?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                { 
                Model.Bicycles_characteristic Bicycles_characteristic = (from b in FrameNavigate.DB.Bicycles_characteristic where b.Model == idBicycles_characteristic select b).SingleOrDefault();
                FrameNavigate.DB.Bicycles_characteristic.Remove(Bicycles_characteristic);
                FrameNavigate.DB.SaveChanges();
                GridBicycles_characteristic.ItemsSource = FrameNavigate.DB.Bicycles_characteristic.ToList();
                }
                catch
                {
                    MessageBox.Show("Это поле пустое!",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }


        }
    }
}
