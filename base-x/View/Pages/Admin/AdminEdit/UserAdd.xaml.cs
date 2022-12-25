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

namespace base_x.View.Pages.Admin.AdminEdit
{
    /// <summary>
    /// Логика взаимодействия для UserAdd.xaml
    /// </summary>
    public partial class UserAdd : Page
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser.Text) ||
                string.IsNullOrEmpty(tbUserPassword.Password))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                if( FrameNavigate.DB.User.Count(u => u.UserName == tbUser.Text) > 0)
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!",
                                    "Системное сообщение",
                                     MessageBoxButton.OK,
                                     MessageBoxImage.Error);
                }
                try
                {
                    FrameNavigate.DB.User.Add(new Model.User
                    {
                        UserName = tbUser.Text,
                        Userpassword = tbUserPassword.Password
                    });
                    await FrameNavigate.DB.SaveChangesAsync();
                    MessageBox.Show("Аккаунт создан!",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                }

                catch
                {
                    MessageBox.Show("Системная ошибка!",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }
    }
}
