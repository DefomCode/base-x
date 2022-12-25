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
    /// Логика взаимодействия для ReviewAdd.xaml
    /// </summary>
    public partial class ReviewAdd : Page
    {
        public ReviewAdd()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbBikeCode.Text) ||
                string.IsNullOrEmpty(tbReview.Text))
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
                    FrameNavigate.DB.Review.Add(new Model.Review
                    {
                        Client_Review = tbReview.Text,
                        Bicycle_code = int.Parse(tbBikeCode.Text),
                    });
                    await FrameNavigate.DB.SaveChangesAsync();
                    MessageBox.Show("Отзыв создан!",
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
