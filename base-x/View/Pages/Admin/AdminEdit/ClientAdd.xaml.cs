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
    /// Логика взаимодействия для ClientAdd.xaml
    /// </summary>
    public partial class ClientAdd : Page
    {
        public ClientAdd()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(tbClientName.Text) ||
                string.IsNullOrEmpty(tbPhone.Text))
            {
                MessageBox.Show("Все обязательные поля должны быть заполнены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                if (FrameNavigate.DB.Client.Count(u => u.Client_name == tbClientName.Text) > 0)
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!",
                                    "Системное сообщение",
                                     MessageBoxButton.OK,
                                     MessageBoxImage.Error);
                }
                else
                {
                    try
                    {
                        switch (tbReviewCode.Text)
                    {
                        case "":
                            FrameNavigate.DB.Client.Add(new Model.Client
                            {
                                Client_name = tbClientName.Text,
                                Phone = decimal.Parse(tbPhone.Text),

                            });
                            await FrameNavigate.DB.SaveChangesAsync();
                            MessageBox.Show("Клиент успешно записан!",
                                            "Системное сообщение",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Information);
                            break;

                        default:
                            FrameNavigate.DB.Client.Add(new Model.Client
                            {
                                Client_name = tbClientName.Text,
                                Review_code = int.Parse(tbReviewCode.Text),
                                Phone = decimal.Parse(tbPhone.Text),

                            });
                            await FrameNavigate.DB.SaveChangesAsync();
                            MessageBox.Show("Клиент успешно записан!",
                                            "Системное сообщение",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Information);
                            break;
                    }
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
}
