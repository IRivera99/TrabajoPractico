using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaDatos.Servicios;
using LibreriaDatos.Dominio;
using LibreriaDatos.Fabricas;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IServicios servicios;

        public UsuariosController()
        {
            servicios = new Fabrica().CrearServicio();
        }

        [HttpPost("VerificarUsuario/")]
        public IActionResult PostLogin(Usuario oUsuario)
        {
            return Ok(servicios.ObtenerCredencial(oUsuario));            
        }
    }
}
