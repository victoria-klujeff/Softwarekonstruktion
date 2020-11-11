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
    /// Interaction logic for UserControlCustomers.xaml
    /// </summary>
    public partial class UserControlCustomers : UserControl
    {
        ClassBIZ BIZ;
        public UserControlCustomers(ClassBIZ inBIZ)
        {
            InitializeComponent();
            BIZ = inBIZ;
            CustomerMainGrid.DataContext = BIZ;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            ButtonVisibilityRevert();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            ButtonVisibilityRevert();

        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            ButtonVisibility();
        }


        private void ButtonRegret_Click(object sender, RoutedEventArgs e)
        {
            ButtonVisibility();

        }


        public void ButtonVisibility()
        {
            this.ButtonCreate.Visibility = Visibility.Hidden;
            this.ButtonEdit.Visibility = Visibility.Hidden;
            this.ButtonSave.Visibility = Visibility.Visible;
            this.ButtonRegret.Visibility = Visibility.Visible;
        }

        public void ButtonVisibilityRevert()
        {
            this.ButtonCreate.Visibility = Visibility.Visible;
            this.ButtonEdit.Visibility = Visibility.Visible;
            this.ButtonSave.Visibility = Visibility.Hidden;
            this.ButtonRegret.Visibility = Visibility.Hidden;
        }
    }
}
