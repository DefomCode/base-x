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
    /// Логика взаимодействия для Bicycles_characteristicAdd.xaml
    /// </summary>
    public partial class Bicycles_characteristicAdd : Page
    {
        public Bicycles_characteristicAdd()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbModel.Text) ||
               string.IsNullOrEmpty(tbMaterial.Text) ||
               string.IsNullOrEmpty(tbBrakeType.Text) ||
               string.IsNullOrEmpty(tbSeatMaterial.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                if (FrameNavigate.DB.Bicycles_characteristic.Count(u => u.Model == tbModel.Text) > 0)
                {
                    MessageBox.Show("Эта модель уже существует!",
                                    "Системное сообщение",
                                     MessageBoxButton.OK,
                                     MessageBoxImage.Error);
                }
                try
                {
                    FrameNavigate.DB.Bicycles_characteristic.Add(new Model.Bicycles_characteristic
                    {
                        Model = tbModel.Text,
                        Material = tbMaterial.Text,
                        Brake_type = tbBrakeType.Text,
                        Seat_material = tbSeatMaterial.Text,
                    });
                    await FrameNavigate.DB.SaveChangesAsync();
                    MessageBox.Show("Модель велосипеда создана!",
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
