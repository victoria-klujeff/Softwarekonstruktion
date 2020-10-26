using BIZ;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ;
        public MainWindow()
        {
            InitializeComponent();
            BIZ = new ClassBIZ();
            MainGrid.DataContext = BIZ;
        }

        private void ButtonCitySearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BIZ.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            
        }

        /// <summary>
        /// This eventhandler enables a press on the enter button to prompt a search and fetch of the information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCitySearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                {
                    BIZ.GetData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
