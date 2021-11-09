
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDatos.Dominio;
using LibreriaDatos.Fabricas;
using LibreriaDatos.Datos;


namespace LibreriaDatos.Servicios
{
    class Servicios : IServicios
    {
        private ICarreraDao carreraDao = new Fabrica().CrearCarreraDao();
        private IAsignaturaDao asignaturaDao = new Fabrica().CrearAsignaturaDao();
        private IUsuariosDao usuarioDao = new Fabrica().CrearUsuarioDao();

        #region Servicios para las asignatuas
        public bool AgregarAsignatua(List<Asignatura> lst)
        {
            return asignaturaDao.AgregarAsignatua(lst);
        }

        public bool BorrarAsignatura(int id)
        {
            return asignaturaDao.BorrarAsignatura(id);
        }

        public bool ModificarAsignatura(List<Asignatura> listaAsignatura)
        {
            return asignaturaDao.ModificarAsignatura(listaAsignatura);
        }

        public List<Asignatura> ObtenerAsignaturas()
        {
            return asignaturaDao.ObtenerAsignaturas();
        }

        public List<int> ObtenerIdAsignaturas()
        {
            return asignaturaDao.ObtenerIdAsignaturas();
        }

        public int ObtenerProximoID()
        {
            return asignaturaDao.ObtenerProximoID();
        }

        #endregion

        #region Servicios para las carreras

        public Carrera ConsultarCarrera(int idCarrera)
        {
            return carreraDao.ConsultarCarrera(idCarrera);
        }      
        
        public bool InsertarCarrera(Carrera carrera)
        {
            return carreraDao.InsertarCarrera(carrera);
        }

        public bool ModificarCarrera(Carrera carrera)
        {
            return carreraDao.ModificarCarrera(carrera);
        }

        public bool BorrarCarrera(int id)
        {
            return carreraDao.BorrarCarrera(id);
        }

        public List<Carrera> ObtenerCarreras()
        {
            return carreraDao.ObtenerCarreras();
        }   

        public List<int> ObtenerIdCarreras()
        {
            return carreraDao.ObtenerIdCarreras();
        }
                
        public int ObtenerProximoIdCarrera()
        {
            return carreraDao.ObtenerProximoIdCarrera();
        }
        #endregion

        public bool ObtenerCredencial(Usuario oUsuario)
        {
            return usuarioDao.ObtenerCredencial(oUsuario);
        }
    }
}
