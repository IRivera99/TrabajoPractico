using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDatos.Dominio;

namespace LibreriaDatos.Datos
{
    public interface IAsignaturaDao
    {
        List<Asignatura> ObtenerAsignaturas();
        int ObtenerProximoID();
        bool BorrarAsignatura(int id);
        bool AgregarAsignatua(List<Asignatura> lst);
        public bool ModificarAsignatura(List<Asignatura> listaAsignaturas);
        List<int> ObtenerIdAsignaturas();
    }
}
