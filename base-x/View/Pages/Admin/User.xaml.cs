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

namespace base_x.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Page
    {
        public User()
        {
            InitializeComponent();

            GridUser.ItemsSource = FrameNavigate.DB.User.ToList();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idUser = (GridUser.SelectedItem as Model.User).UserID;
            var result = MessageBox.Show("Хотите удалить ?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Model.User User = (from b in FrameNavigate.DB.User where b.UserID == idUser select b).SingleOrDefault();
                    FrameNavigate.DB.User.Remove(User);
                    FrameNavigate.DB.SaveChanges();
                    GridUser.ItemsSource = FrameNavigate.DB.User.ToList();
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

