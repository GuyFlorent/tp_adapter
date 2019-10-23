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
using Pattern_Adapter;
namespace Tp_Adapter
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private IVehicule monVehicule;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string type_vehicule = cmb_Vehicule.Text;

            switch (type_vehicule)
            {
                case "Avion":
                    monVehicule = new Avion();
                    break;
                case "Voiture":
                    monVehicule = new Voiture();
                    break;
                case "Moto":
                    monVehicule = new Moto();
                    break;
                default:
                    break;
            }

            monVehicule.Rouler();
        }

        private VehiculeAdapte _vehiculeAdapte;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (monVehicule != null)
            {
                _vehiculeAdapte = new VehiculeAdapte(monVehicule);
                _vehiculeAdapte.RoulerAdapte();
            }
            else
                Console.WriteLine("VehiculeAdapte null");
        }
    }
}
