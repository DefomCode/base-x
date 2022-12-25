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
    /// Логика взаимодействия для BicycleAdd.xaml
    /// </summary>
    public partial class BicycleAdd : Page
    {
        public BicycleAdd()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbBicycleName.Text) ||
                string.IsNullOrEmpty(tbModel.Text) ||
                string.IsNullOrEmpty(tbPrice.Text) ||
                string.IsNullOrEmpty(tbColor.Text))
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
                    FrameNavigate.DB.Bicycle.Add(new Model.Bicycle
                    {
                        Bicycle_name = tbBicycleName.Text,
                        Model = tbModel.Text,
                        Price = int.Parse(tbPrice.Text),
                        Сolor = tbColor.Text,
                    });
                    await FrameNavigate.DB.SaveChangesAsync();
                    MessageBox.Show("Велосипед создан!",
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
