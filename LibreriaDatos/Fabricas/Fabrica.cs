using LibreriaDatos.Datos;
using LibreriaDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDatos.Fabricas
{
    public class Fabrica : AbstractFabrica
    {
        public override IServicios CrearServicio()
        {
            return new Servicios.Servicios();
        }

        public override ICarreraDao CrearCarreraDao()
        {
            return new CarreraDao();
        }

        public override IAsignaturaDao CrearAsignaturaDao()
        {
            return new AsignaturaDao();
        }

        public override IUsuariosDao CrearUsuarioDao()
        {
            return new UsuariosDao();
        }
    }
}
