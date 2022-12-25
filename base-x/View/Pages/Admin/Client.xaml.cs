using base_x.Core;
using base_x.Model;
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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Page
    {
        public Client()
        {
            InitializeComponent();

            GridClient.ItemsSource = FrameNavigate.DB.Client.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idClient = (GridClient.SelectedItem as Model.Client).Client_code;
            var result = MessageBox.Show("Хотите удалить клиента?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try 
                { 
                Model.Client Client = (from b in FrameNavigate.DB.Client where b.Client_code == idClient select b).SingleOrDefault();
                FrameNavigate.DB.Client.Remove(Client);
                FrameNavigate.DB.SaveChanges();
                GridClient.ItemsSource = FrameNavigate.DB.Client.ToList();
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

