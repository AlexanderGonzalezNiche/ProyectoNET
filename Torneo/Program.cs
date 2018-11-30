using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test servicio temperatura
            var ws = new servicioTemperatura.TempServ();

            Double temp = ws.darTemperatura("Montevideo");
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
