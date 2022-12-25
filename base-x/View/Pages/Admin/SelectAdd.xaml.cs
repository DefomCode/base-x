using base_x.Core;
using base_x.View.Pages.Admin.AdminEdit;
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

namespace base_x.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для SelectAdd.xaml
    /// </summary>
    public partial class SelectAdd : Page
    {
        public SelectAdd()
        {
            InitializeComponent();
        }

        private void btn_Bicycle_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new BicycleAdd();
        }

        private void btn_Bicycles_characteristic_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new Bicycles_characteristicAdd();
        }

        private void btn_order_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new OrderAdd();
        }

        private void btn_review_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new ReviewAdd();
        }

        private void btn_client_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new ClientAdd();
        }

        private void btn_client_adress_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new Client_adressAdd();
        }

        private void btn_user_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new UserAdd();
        }

        private async void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {
            await FrameNavigate.DB.SaveChangesAsync();
            MessageBox.Show("Изменения успешно сохранены!",
                            "Системное уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }
    }
}
