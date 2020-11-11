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

namespace CalculatorUnitTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassCalc CC;
        public MainWindow()
        {
            InitializeComponent();
            CC = new ClassCalc();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CC.BeregnAlt(Convert.ToInt32(TextBoxTal1.Text), Convert.ToInt32(TextBoxTal2.Text));

            LabelPlus.Content = CC.resPlus.ToString();
            LabelMinus.Content = CC.resMinus.ToString();
            LabelGange.Content = CC.resGange.ToString();
            LabelDivider.Content = CC.resDivider.ToString();
        }


    }
}
