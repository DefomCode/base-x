using base_x.View.Pages;
using base_x.View.Pages.Admin;
using base_x.View.Pages.Guest;
using System.Windows;
using System.Windows.Controls;

namespace base_x.View.UserPages
{
    /// <summary>
    /// Логика взаимодействия для Admin_Page.xaml
    /// </summary>
    public partial class Admin_Page : Page
    {
        public Admin_Page()
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
                AdminFrame.Content = new Bicycles_characteristic();
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
                AdminFrame.Content = new Bicycles();
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

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AdminFrame.Content = new Order();
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
                AdminFrame.Content = new Review();
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

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AdminFrame.Content = new Client();
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

        private void Client_adress_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AdminFrame.Content = new Client_adress();
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

        private void User_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AdminFrame.Content = new User();
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
                AdminFrame.Content = new SelectAdd();          
        }
    }
}
