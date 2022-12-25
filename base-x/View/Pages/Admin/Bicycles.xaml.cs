using base_x.Core;
using base_x.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Bicycles.xaml
    /// </summary>
    public partial class Bicycles : Page
    {
        public Bicycles()
        {
            InitializeComponent();

            GridBicycle.ItemsSource = FrameNavigate.DB.Bicycle.ToList();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idBicycle = (GridBicycle.SelectedItem as Bicycle).Bicycle_code;
            var result = MessageBox.Show("Хотите удалить велосипед?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                try
                { 
                Bicycle Bicycle = (from b in FrameNavigate.DB.Bicycle where b.Bicycle_code == idBicycle select b).SingleOrDefault();
                FrameNavigate.DB.Bicycle.Remove(Bicycle);
                FrameNavigate.DB.SaveChanges();
                GridBicycle.ItemsSource = FrameNavigate.DB.Bicycle.ToList();
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
