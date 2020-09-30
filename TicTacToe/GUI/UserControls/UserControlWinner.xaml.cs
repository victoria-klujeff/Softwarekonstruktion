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
    /// Interaction logic for UserControlWinner.xaml
    /// </summary>
    public partial class UserControlWinner : UserControl
    {
        Grid _grid;

        /// <summary>
        /// We send our parameters so they can be displayed on the GUI
        /// What is displayed is determined by our if statement.
        /// We display through our label.content which is in the xaml
        /// </summary>
        /// <param name="stringWinner"></param>
        /// <param name="inGrid"></param>
        public UserControlWinner(string stringWinner, Grid inGrid, int intScoreCountO, int intScoreCountX)
        {
            InitializeComponent();
            _grid = inGrid;

            if (stringWinner.ToUpper() == "O")
            {
                labelWinnerText.Content = $"Tillykke O har vundet " +
                    $" O har vundet {intScoreCountO} gange og X har vundet {intScoreCountX} gange";
                labelWinnerText.Background = Brushes.Blue;
                labelWinnerText.Foreground = Brushes.White;
            }
            else
            {
                labelWinnerText.Content = $"Tillykke X har vundet " +
                    $" O har vundet {intScoreCountO} gange og X har vundet {intScoreCountX} gange";
                labelWinnerText.Background = Brushes.Red;
                labelWinnerText.Foreground = Brushes.White;
            }
        }

        /// <summary>
        /// eventhandler for label
        /// Triggered by doubleclick, the box is then removed by clearing the _grid child
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelWinnerText_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _grid.Children.Clear();
        }
    }
}
