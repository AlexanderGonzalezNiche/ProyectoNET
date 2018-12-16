using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo_Clases.Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test servicio temperatura
            var ws = new ServicioClima.TempServ();

            Double temp = ws.darTemperatura("Montevideo");
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
