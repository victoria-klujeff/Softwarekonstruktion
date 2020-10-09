using Microsoft.Win32;
using System.Windows;
using BIZ;

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

            mainGrid.DataContext = BIZ;
        }

        private void ButtonLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            // Open file dialog by using OpenFileDialog method 
            // Use condition to check if any actions have been taken in the dialog box
            // Then we check if a file has been choosen 
            // If true we call our method and send a parameter myPath with it 
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string myPath = "";

            if (openFileDialog.ShowDialog() == true)
            {
                myPath = openFileDialog.FileName;
            }
            if (myPath.Trim().Length > 0)
            {
                BIZ.OpenFile(myPath);
            }
        }

        // Open file dialog by using OpenFileDialog method 
        // Use condition to check if any actions have been taken in the dialog box
        // Then we check if a file has been choosen 
        // If true we call our method and send a parameter myPath with it
        private void ButtonSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string myPath = "";

            if (saveFileDialog.ShowDialog() == true) 
            {
                myPath = saveFileDialog.FileName;
            }
            if (myPath.Trim().Length > 0)
            {
                BIZ.SaveTextToFile(myPath);
            }
        }

       
        private void ButtonEncrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.StartCrypt(); // Method call to StartCrypt in ClassBIZ
        }


        private void ButtonDecrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.StartDecrypt(); // Method call to StartDecrypt in ClassBIZ
        }

        private void ButtonRollingEncrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.StartRollingCrypt(); // Method call to StartRollingCrypt in ClassBIZ
        }

        private void ButtonRollingDecrypt_Click(object sender, RoutedEventArgs e)
        {
            BIZ.StartRollingDecrypt(); // Method call to StartRollinDecrypt in ClassBIZ

        }
    }
}
