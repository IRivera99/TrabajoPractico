using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaDatos.Servicios;
using LibreriaDatos.Dominio;
using LibreriaDatos.Fabricas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrerasController : ControllerBase
    {
        private IServicios servicios;

        public CarrerasController()
        {
            servicios = new Fabrica().CrearServicio();
        }

        [HttpGet("/ConsularCarreras")]
        public IActionResult ConsultarCarreras()
        {
            return Ok(servicios.ObtenerCarreras());
        }

        [HttpGet("/ConsultarCarerraPorId/{id}")]
        public IActionResult ConsultarCarrerasPorId(int id)
        {
            return Ok(servicios.ConsultarCarrera(id));
        }

        [HttpGet("/ConsultarIdCarreras")]
        public IActionResult ConsultarIdCarreras()
        {
            return Ok(servicios.ObtenerIdCarreras());
        }

        [HttpPost("/InsertarCarreras")]
        public IActionResult InsertarCarreras(Carrera carrera)
        {
            return Ok(servicios.InsertarCarrera(carrera));
        }

        [HttpDelete("/BorrarCarreras/{id}")]
        public IActionResult BorrarCarreras(int id)
        {
           return Ok(servicios.BorrarCarrera(id));
        }

        [HttpPut("/ModificarCarreras")]
        public IActionResult ModificarCarreras(Carrera carrera)
        {
            return Ok(servicios.ModificarCarrera(carrera));
        }

    }
}
