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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace animacja_3d
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void scrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            table.Transform = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(1, 0, 0), vScroll.Value));   
        }

        private void scrollBar_ValueChanged1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            table.Transform = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 1, 0), hScroll.Value));
        }
    }
}
