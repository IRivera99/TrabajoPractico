using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDatos.Dominio;

namespace LibreriaDatos.Datos
{
    public interface IUsuariosDao
    {
        bool ObtenerCredencial(Usuario oUsuario);
    }
}
