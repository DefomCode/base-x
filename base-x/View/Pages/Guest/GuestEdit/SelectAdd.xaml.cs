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

namespace base_x.View.Pages.Guest.GuestEdit
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

        private void btn_Review_Click(object sender, RoutedEventArgs e)
        {
            FrameSelectAdd.Content = new ReviewAdd();
        }
    }
}
