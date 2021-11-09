using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDatos.Dominio;
using LibreriaDatos.Servicios;

namespace LibreriaDatos.Datos
{
    public interface ICarreraDao
    {
        int ObtenerProximoIdCarrera();
        bool InsertarCarrera(Carrera oCarrera);
        bool ModificarCarrera(Carrera oCarrera);
        bool BorrarCarrera(int id);
        List<Carrera> ObtenerCarreras();
        List<int> ObtenerIdCarreras();
        Carrera ConsultarCarrera(int idCarrera);
    }
}
