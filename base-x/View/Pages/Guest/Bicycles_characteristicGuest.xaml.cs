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
    /// Логика взаимодействия для Bicycles_characteristicGuest.xaml
    /// </summary>
    public partial class Bicycles_characteristicGuest : Page
    {
        public Bicycles_characteristicGuest()
        {
            InitializeComponent();

            GridBicycles_characteristic.ItemsSource = FrameNavigate.DB.Bicycles_characteristic.ToList();
        }
    }
}
