using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Torneo_Clases;

namespace Torneo_WebApi.Controllers
{
    public class UsuarioController : ApiController
    {

        public IHttpActionResult loguearse(String usuario, String pass)
        {
            Fachada fachada = new Fachada();
            if (fachada.LoginCorrecto(usuario, pass))
            {

                return Ok(true);
            }

            else
                return Ok(false);
        }
    }
}