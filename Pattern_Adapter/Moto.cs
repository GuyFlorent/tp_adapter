using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{
   public class Moto : IVehicule
    {
        public void Rouler()
        {
            Console.WriteLine("Démarrage Moto");

        }
    }
}
