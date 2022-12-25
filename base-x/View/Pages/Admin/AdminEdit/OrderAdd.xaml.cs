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
    /// Логика взаимодействия для OrderAdd.xaml
    /// </summary>
    public partial class OrderAdd : Page
    {
        public OrderAdd()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbBicycleCode.Text) ||
              string.IsNullOrEmpty(tbClientCode.Text) ||
              string.IsNullOrEmpty(tbDataTime.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    FrameNavigate.DB.Order.Add(new Model.Order
                    {
                        Bicycle_code = int.Parse(tbBicycleCode.Text),
                        Client_code = int.Parse(tbClientCode.Text),
                        Date_order = DateTime.Parse(tbDataTime.Text),
                    });
                    await FrameNavigate.DB.SaveChangesAsync();
                    MessageBox.Show("Заказ создан!",
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
