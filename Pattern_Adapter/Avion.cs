using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{
    public class Avion : IVehicule
    {
        public void Rouler()
        {
            Console.WriteLine("Décollage Avion");
        }
    }
}
