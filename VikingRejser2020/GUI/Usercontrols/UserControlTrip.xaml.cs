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
using BIZ;
using Repository;

namespace GUI
{
    /// <summary>
    /// Interaction logic for UserControlTrip.xaml
    /// </summary>
    public partial class UserControlTrip : UserControl
    {
        ClassBIZ BIZ;
        public UserControlTrip(ClassBIZ inBIZ)
        {
            InitializeComponent();
            BIZ = inBIZ;
            TripMainGrid.DataContext = BIZ;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRegret_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
