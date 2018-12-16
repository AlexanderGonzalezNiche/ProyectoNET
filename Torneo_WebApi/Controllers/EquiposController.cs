using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Torneo_Clases;
using Torneo_Clases.Value_Objects;

namespace Torneo_WebApi.Controllers
{
    public class EquiposController : ApiController
    {
        public IEnumerable<VOEquipo> GetAllEquipos()
        {
            Fachada fachada = new Fachada();
            return fachada.DevolverEquipos();
        }
    }
}