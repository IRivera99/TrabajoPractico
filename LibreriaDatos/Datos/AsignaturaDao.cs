using LibreriaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibreriaDatos.Datos
{
    class AsignaturaDao : IAsignaturaDao
    {

        public bool AgregarAsignatua(List<Asignatura> lst)
        {
            bool flag;
            flag = HelperDao.ObtenerInstancia().InsertarAsignatura("SP_INSERTAR_ASIGNATURA", lst);
            return flag;
        }

        public bool BorrarAsignatura(int id)
        {
            bool flag = true;

            flag = HelperDao.ObtenerInstancia().Borrar("SP_BORRAR_ASIGNATURA", id, "@idAsignatura");
            
            return flag;            
        }

        public bool ModificarAsignatura(List<Asignatura> listaAsignaturas)
        {
            bool flag = false;
            foreach (Asignatura asignatura in listaAsignaturas)
            {
                flag = HelperDao.ObtenerInstancia().Modificar("SP_MODIFICAR_ASIGNATURA", asignatura.IdAsignatura, "@idAsignatura", asignatura.Nombre, "@nAsignatura");
            }
            return flag;
        }

        public List<Asignatura> ObtenerAsignaturas()
        {
            List<Asignatura> lst = new List<Asignatura>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQL("SP_COSULTAR_ASIGNATURAS");
            foreach (DataRow row in tabla.Rows)
            {
                Asignatura oAsignatura = new Asignatura();
                oAsignatura.IdAsignatura = Convert.ToInt32(row["idAsignatura"]);
                oAsignatura.Nombre = row["nAsignatura"].ToString();
                lst.Add(oAsignatura);
            }
            return lst;
        }

        public List<int> ObtenerIdAsignaturas()
        {
            List<int> lst = new List<int>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQL("SP_COSULTAR_ASIGNATURAS_ID");
            foreach (DataRow row in tabla.Rows)
            {
                Asignatura oAsignatura = new Asignatura();
                oAsignatura.IdAsignatura = Convert.ToInt32(row["idAsignatura"].ToString());
                //oAsignatura.Nombre = row["nAsignatura"].ToString();
                lst.Add(oAsignatura.IdAsignatura);
            }
            return lst;
        }

        public int ObtenerProximoID()
        {
            return HelperDao.ObtenerInstancia().ProximoID("SP_PROXIMO_ID_ASIGNATURA", "@proximo");
        }
    }
}
