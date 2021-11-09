using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDatos.Servicios;
using LibreriaDatos.Datos;

namespace LibreriaDatos.Fabricas
{
    public abstract class AbstractFabrica
    {
        public abstract IServicios CrearServicio();
        public abstract ICarreraDao CrearCarreraDao();
        public abstract IAsignaturaDao CrearAsignaturaDao();
        public abstract IUsuariosDao CrearUsuarioDao();
    }
}
