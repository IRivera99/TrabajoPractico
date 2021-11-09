using LibreriaDatos.Servicios;
using LibreriaDatos.Dominio;
using LibreriaDatos.Fabricas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturasController : ControllerBase
    {
        private IServicios servicios; 

        public AsignaturasController()
        {
            servicios = new Fabrica().CrearServicio();
        }

        [HttpGet("/ConsultarAsignaturas")]
        public IActionResult ConsultarAsignaturas()
        {
            return Ok(servicios.ObtenerAsignaturas());
        }     
        
        [HttpGet("/ConsultarIdAsignaturas")]
        public IActionResult ConsultarIdAsignaturas()
        {
            return Ok(servicios.ObtenerIdAsignaturas());
        }

        [HttpPost("/InsertarAsignaturas")]
        public IActionResult InsertarAsignaturas(List<Asignatura> listaAsignaturas)
        {
            return Ok(servicios.AgregarAsignatua(listaAsignaturas));
        }

        [HttpDelete("/BorrarAsignaturas/{id}")]
        public IActionResult BorrarAsignaturas(int id)
        {
            return Ok(servicios.BorrarAsignatura(id));
        }

        [HttpPut("/ModificarAsignaturas")]
        public IActionResult ModificarAsignaruras(List<Asignatura> listaAsignaturas)
        {
            return Ok(servicios.ModificarAsignatura(listaAsignaturas));
        }
    }
}
