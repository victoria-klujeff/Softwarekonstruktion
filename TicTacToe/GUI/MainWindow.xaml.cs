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

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassTextBoxHandler CTBH; // New instance of ClassTextBoxHandler 

        public MainWindow()
        {
            InitializeComponent();
            CTBH = new ClassTextBoxHandler();
            MainGrid.DataContext = CTBH;
        }

        /// <summary>
        /// All nine Textboxes are linked to this eventhandler 
        /// Every time a double tap is performed a sign is put onto the GUI and we check for a winner 
        /// If we have a winner we create a new instance of Usercontrolwinner and transfer our parameter and a instance of winnergrid
        /// An instance of usercontrolwinner is added to winnerggrid
        /// The game is reset and initialized so a new game can begin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (CTBH.RegTextBoxClick(textBox.Tag.ToString()))
            {
                UserControlWinner UCW = new UserControlWinner(CTBH.actualSign, this.WinnerGrid, CTBH.intScoreCountO, CTBH.intScoreCountX);
                WinnerGrid.Children.Add(UCW);
                CTBH.ResetAll();
            }
        }
    }
}
