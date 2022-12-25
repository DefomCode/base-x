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
    /// Логика взаимодействия для Client_adressAdd.xaml
    /// </summary>
    public partial class Client_adressAdd : Page
    {
        public Client_adressAdd()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {
            int ClientCode = int.Parse(tbClientCode.Text);
            int PostalCode = int.Parse(tbPostalCode.Text);

            if (string.IsNullOrEmpty(tbClientCode.Text) ||
                string.IsNullOrEmpty(tbAdress.Text) ||
                string.IsNullOrEmpty(tbCity.Text) ||
                string.IsNullOrEmpty(tbPostalCode.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                if (FrameNavigate.DB.Client_adress.Count(u => u.Client_code == ClientCode) > 0)
                {
                    MessageBox.Show("Этот пользователь уже вписал адрес!",
                                    "Системное сообщение",
                                     MessageBoxButton.OK,
                                     MessageBoxImage.Error);
                }
                else
                {
                    try
                    { 
                    FrameNavigate.DB.Client_adress.Add(new Model.Client_adress
                    {
                        Client_code = int.Parse(tbClientCode.Text),
                        Adress = tbAdress.Text,
                        City = tbCity.Text,
                        Postal_code = int.Parse(tbPostalCode.Text),
                    });
                        await FrameNavigate.DB.SaveChangesAsync();
                        MessageBox.Show("Адрес вписан!",
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
}
