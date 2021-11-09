using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDatos.Dominio;

namespace LibreriaDatos.Datos
{
    class UsuariosDao : IUsuariosDao
    {
        public bool ObtenerCredencial(Usuario oUsuario)
        {
            return HelperDao.ObtenerInstancia().ValidarUsuario("SP_CONSULTAR_USUARIO", oUsuario.NUsuario, oUsuario.Contraseña);
        }
    }
}
