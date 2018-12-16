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
            var ws = new servicioWebClima.WebServiceClima();
            string ciudad = "Colonia";
            double temp = ws.darTemperatura(ciudad);
            double velViento = ws.darVelocidadViento(ciudad);
            string nubocidad = ws.darNubosidad(ciudad);

            string clima = "El clima estaba: " + nubocidad + " temperatura " + temp + " velocidad del viento " + velViento;
            Console.WriteLine(clima);
            Console.ReadLine();
        }
    }
}
