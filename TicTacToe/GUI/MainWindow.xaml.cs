﻿using System;
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
        ClassTextBoxHandler CTBH;
        public MainWindow()
        {
            InitializeComponent();
            CTBH = new ClassTextBoxHandler();
            MainGrid.DataContext = CTBH;
        }
        private void textBoxDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (CTBH.RegTextBoxClick(textBox.Tag.ToString()))
            {
                UserControlWinner UCW = new UserControlWinner(CTBH.actualSign, this.WinnerGrid);
                WinnerGrid.Children.Add(UCW);
                CTBH.ResetAll();
            }
        }
    }
}
