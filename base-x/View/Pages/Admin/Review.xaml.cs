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

namespace base_x.View.Pages.Guest
{
    /// <summary>
    /// Логика взаимодействия для Review.xaml
    /// </summary>
    public partial class Review : Page
    {
        public Review()
        {
            InitializeComponent();

            GridReview.ItemsSource = FrameNavigate.DB.Bicycle.ToList();
            GridReview.ItemsSource = FrameNavigate.DB.Review.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idReview = (GridReview.SelectedItem as Model.Review).Review_code;
            var result = MessageBox.Show("Хотите удалить отзыв?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                { 
                Model.Review Review = (from b in FrameNavigate.DB.Review where b.Review_code == idReview select b).SingleOrDefault();
                FrameNavigate.DB.Review.Remove(Review);
                FrameNavigate.DB.SaveChanges();
                GridReview.ItemsSource = FrameNavigate.DB.Review.ToList();
                }
                catch
                {
                    MessageBox.Show("Это поле пустое!",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }

        }
    }
}
