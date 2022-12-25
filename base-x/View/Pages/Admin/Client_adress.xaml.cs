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
    /// Логика взаимодействия для Client_adress.xaml
    /// </summary>
    public partial class Client_adress : Page
    {
        public Client_adress()
        {
            InitializeComponent();

            GridClient_adress.ItemsSource = FrameNavigate.DB.Client_adress.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idClient_adress = (GridClient_adress.SelectedItem as Model.Client_adress).Adress_code;
            var result = MessageBox.Show("Хотите удалить адрес клиента?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                { 
                Model.Client_adress Client_adress = (from b in FrameNavigate.DB.Client_adress where b.Adress_code == idClient_adress select b).SingleOrDefault();
                FrameNavigate.DB.Client_adress.Remove(Client_adress);
                FrameNavigate.DB.SaveChanges();
                GridClient_adress.ItemsSource = FrameNavigate.DB.Client_adress.ToList();
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
