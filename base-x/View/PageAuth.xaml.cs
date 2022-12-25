using base_x.Core;
using base_x.Model;
using base_x.View;
using base_x.View.UserPages;
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

namespace base_x.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Page
    {
        public PageAuth()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User UserModel = FrameNavigate.DB.User.FirstOrDefault(u =>
                u.UserName == tbLogin.Text && u.Userpassword == tbPassword.Password);

                if (UserModel == null)
                {
                    MessageBox.Show("Вы ввели не верные данные!",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    FrameNavigate.FrameObject.Navigate(new Admin_Page());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системная ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void btnGo_guest_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new Guest_page());
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
