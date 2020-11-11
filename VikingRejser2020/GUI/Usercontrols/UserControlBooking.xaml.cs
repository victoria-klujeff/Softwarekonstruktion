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
    /// Interaction logic for UserControlBooking.xaml
    /// </summary>
    public partial class UserControlBooking : UserControl
    {
        ClassBIZ BIZ;
        public UserControlBooking(ClassBIZ inBIZ)
        {
            InitializeComponent();
            BIZ = inBIZ;
            BookingMainGrid.DataContext = BIZ;
        }

        private void ButtonAddParticipant_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCompleteBooking_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRegretBooking_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
