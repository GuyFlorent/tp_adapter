using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{
   public class VehiculeAdapte
    {

        private IVehicule _vehicule;

        // IVehicule V1 = new Moto();
        // VehiculeAdapte VA1 = new VehiculeAdapte(V1);
        // VA1.DemarrageAdapte();
        public VehiculeAdapte( IVehicule autreVehicule)
        {
            this._vehicule = autreVehicule;
        }

        public void RoulerAdapte()
        {
            Console.WriteLine("Début du démarrage Adapté");
            this._vehicule.Rouler();
            Console.WriteLine("Fin du démarrage Adapté");

        }

    }
}
