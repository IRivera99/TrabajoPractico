using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDatos.Dominio;

namespace LibreriaDatos.Servicios
{
    public interface IServicios
    {
        //Asignaturas
        public List<Asignatura> ObtenerAsignaturas();
        public int ObtenerProximoID();
        public bool BorrarAsignatura(int id);
        public bool AgregarAsignatua(List<Asignatura> lst);
        public bool ModificarAsignatura(List<Asignatura> listaAsignatura);
        public List<int> ObtenerIdAsignaturas();

        //Carreras
        public int ObtenerProximoIdCarrera();
        public bool InsertarCarrera(Carrera carrera);
        public bool ModificarCarrera(Carrera carrera);
        public bool BorrarCarrera(int id);
        public List<Carrera> ObtenerCarreras();
        public List<int> ObtenerIdCarreras();
        public Carrera ConsultarCarrera(int idCarrera);

        //Usuarios
        public bool ObtenerCredencial(Usuario oUsuario);
    }
}
