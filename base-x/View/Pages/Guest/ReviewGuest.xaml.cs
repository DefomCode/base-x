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
    /// Логика взаимодействия для ReviewGuest.xaml
    /// </summary>
    public partial class ReviewGuest : Page
    {
        public ReviewGuest()
        {
            InitializeComponent();

            GridReview.ItemsSource = FrameNavigate.DB.Review.ToList();
        }
    }
}
