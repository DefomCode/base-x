using base_x.Core;
using base_x.Model;
using base_x.View.Pages;
using base_x.View.Pages.Guest;
using base_x.View.Pages.Guest.GuestEdit;
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
using Bicycles_characteristic = base_x.View.Pages.Bicycles_characteristic;
using Review = base_x.View.Pages.Guest.Review;

namespace base_x.View
{
    /// <summary>
    /// Логика взаимодействия для Guest_page.xaml
    /// </summary>
    public partial class Guest_page : Page
    {
        public Guest_page()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Bicycles_characteristic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GuestFrame.Content = new Bicycles_characteristicGuest();
            }
            catch
            {
                {
                    MessageBox.Show("База данных не подключена!",
                                    "Системная ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }

        private void Bicycle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GuestFrame.Content = new BicyclesGuest();
            }
            catch
            {
                {
                    MessageBox.Show("База данных не подключена!",
                                    "Системная ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }

        private void Review_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GuestFrame.Content = new ReviewGuest();
            }
            catch
            {
                {
                    MessageBox.Show("База данных не подключена!",
                                    "Системная ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GuestFrame.Content = new SelectAdd();
            }
            catch
            {
                {
                    MessageBox.Show("База данных не подключена!",
                                    "Системная ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }
    }
}
