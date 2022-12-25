using base_x.Core;
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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Page
    {
        public Order()
        {
            InitializeComponent();

            GridOrder.ItemsSource = FrameNavigate.DB.Order.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idOrder = (GridOrder.SelectedItem as Model.Order).Order_code;
            var result = MessageBox.Show("Хотите удалить характеристики велосипеда?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                { 
                Model.Order order = (from b in FrameNavigate.DB.Order where b.Order_code == idOrder select b).SingleOrDefault();
                FrameNavigate.DB.Order.Remove(order);
                FrameNavigate.DB.SaveChanges();
                GridOrder.ItemsSource = FrameNavigate.DB.Order.ToList();
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
