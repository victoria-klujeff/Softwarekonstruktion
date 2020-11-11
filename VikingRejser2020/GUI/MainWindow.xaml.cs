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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ;

        UserControlTrip UCT;
        UserControlBooking UCB;
        UserControlCustomers UCC;
        UserControlTransport UCTRA;
        UserControlWeatherForecast UCW;

        public MainWindow()
        {
            InitializeComponent();

            BIZ = new ClassBIZ();

            UCT = new UserControlTrip(BIZ);
            UCB = new UserControlBooking(BIZ);
            UCC = new UserControlCustomers(BIZ);
            UCTRA = new UserControlTransport(BIZ);
            UCW = new UserControlWeatherForecast(BIZ);

            TripGrid.Children.Add(UCT);
            BookingGrid.Children.Add(UCB);
            CustomerGrid.Children.Add(UCC);
            TransportGrid.Children.Add(UCTRA);
            WeatherForecastGrid.Children.Add(UCW);
        }
    }
}
