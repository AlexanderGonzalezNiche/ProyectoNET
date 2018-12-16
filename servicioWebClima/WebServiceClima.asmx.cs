using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace servicioWebClima
{
    /// <summary>
    /// Descripción breve de WebServiceClima
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceClima : System.Web.Services.WebService
    {

        [WebMethod(Description = "Servicio para dar la temperatura de una ciudad")]
        public Double darTemperatura(String ciudad)
        {
            Double temperatura = 0;
            switch (ciudad)
            {
                case "Montevideo":
                    temperatura = 22.0;
                    break;
                case "Maldonado":
                    temperatura = 20.3;
                    break;
                case "Colonia":
                    temperatura = 21.6;
                    break;
                default:
                    temperatura = -100;
                    break;
            }
            return temperatura;
        }

        [WebMethod(Description = "Servicio para dar nubocidad de una ciudad")]
        public String darNubosidad(String ciudad)
        {
            String nubocidad;
            switch (ciudad)
            {
                case "Montevideo":
                    nubocidad = "Soleado";
                    break;
                case "Maldonado":
                    nubocidad = "Claros y nubes";
                    break;
                case "Colonia":
                    nubocidad = "Nublado";
                    break;
                default:
                    nubocidad = "Soleado";
                    break;
            }
            return nubocidad;
        }

        [WebMethod(Description = "Servicio para dar los km/h viento de una ciudad")]
        public Double darVelocidadViento(String ciudad)
        {
            Double velocidad = 0;
            switch (ciudad)
            {
                case "Montevideo":
                    velocidad = 30.5;
                    break;
                case "Maldonado":
                    velocidad = 15.3;
                    break;
                case "Colonia":
                    velocidad = 40.6;
                    break;
                default:
                    velocidad = 10;
                    break;
            }
            return velocidad;
        }
    }
}
