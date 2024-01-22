using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for Customers.xaml
    /// </summary>
    public partial class Customers : UserControl
    {
        public double StrokeDashOffsetValue { get; set; }
        public Customers()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            // Bắt đầu Storyboard khi UserControl được nạp
            Storyboard startAnimation = (Storyboard)FindResource("Start_Animation");
            if (startAnimation != null)
            {
                StrokeDashOffsetValue = 360 * (217.0 / 365.0);
                startAnimation.Begin(this);
            }
        }
    }
}
