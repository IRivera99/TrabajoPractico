using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibreriaDatos.Servicios;
using LibreriaDatos.Dominio;
using LibreriaDatos.Fabricas;


namespace LibreriaDatos.Datos
{
    class CarreraDao : ICarreraDao
    {
        public Carrera ConsultarCarrera(int idCarrera)
        {
            Carrera oCarrera = new Carrera();

            DataTable tablaCarreras = HelperDao.ObtenerInstancia().BusquedaSQL("SP_CONSULTAR_CARRERA_POR_ID", idCarrera, "@idCarrera");
            foreach (DataRow row in tablaCarreras.Rows)
            {
                oCarrera.IdCarrera = Convert.ToInt32(row["idCarrera"]);
                oCarrera.Nombre = row["nCarrera"].ToString();
                oCarrera.Titulo = row["titulo"].ToString();
            }
            
            DataTable tablaDetalles = HelperDao.ObtenerInstancia().BusquedaSQL("SP_CONSULTAR_DETALLESCARRERAS", idCarrera, "@idCarrera");
            foreach (DataRow row in tablaDetalles.Rows)
            {
                DetalleCarrera oDetalle = new DetalleCarrera();
                oDetalle.Asignatura.IdAsignatura = Convert.ToInt32(row["idAsignatura"]);
                oDetalle.Asignatura.Nombre = row["nAsignatura"].ToString();
                oDetalle.Año = Convert.ToInt32(row["aCursado"]);
                oDetalle.Cuatrimestre = Convert.ToInt32(row["cuatrimestre"]);
                oCarrera.AgregarAsignatura(oDetalle);
            }

            return oCarrera;
        }

        public bool InsertarCarrera(Carrera oCarrera)
        {
            bool flag = false;
            int filasA;

            filasA = HelperDao.ObtenerInstancia().EjecutarSQLMaestroDetalle("SP_INSERTAR_CARRERA", "SP_INSERTAR_DETALLESCARRERAS", oCarrera, Parametros.Accion.Crear);
            if (filasA > 0) { flag = true; }

            return flag;
        }

        public bool ModificarCarrera(Carrera oCarrera)
        {
            bool flag = false;
            int filasA;

            if (HelperDao.ObtenerInstancia().Borrar("SP_BORRAR_DETALLESCARRERAS", oCarrera.IdCarrera, "@idCarrera"))
            { flag = true; }
            else { return flag; }

            filasA = HelperDao.ObtenerInstancia().EjecutarSQLMaestroDetalle("SP_MODIFICAR_CARRERA", "SP_INSERTAR_DETALLESCARRERAS", oCarrera, Parametros.Accion.Modificar);

            if (filasA > 0) { flag = true; }

            return flag;
        }

        public bool BorrarCarrera(int id)
        {
            return HelperDao.ObtenerInstancia().Borrar("SP_BORRAR_CARRERA", id, "@idCarrera");
        }

        public List<Carrera> ObtenerCarreras()
        {
            List<Carrera> lst = new List<Carrera>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_CARRERAS");
            foreach (DataRow row in tabla.Rows)
            {
                Carrera oCarrera = new Carrera();
                oCarrera.IdCarrera = Convert.ToInt32(row["idCarrera"]);
                oCarrera.Nombre = row["nCarrera"].ToString();
                lst.Add(oCarrera);
            }
            return lst;
        }

        public List<int> ObtenerIdCarreras()
        {
            List<int> lst = new List<int>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQL("SP_COSULTAR_CARRERAS_ID");
            foreach (DataRow row in tabla.Rows)
            {
                Carrera oCarrera = new Carrera();
                oCarrera.IdCarrera = Convert.ToInt32(row["idCarrera"]);
                lst.Add(oCarrera.IdCarrera);
            }
            return lst;
        }

        public int ObtenerProximoIdCarrera()
        {
            return HelperDao.ObtenerInstancia().ProximoID("SP_PROXIMO_ID","@proximo");
        }
                
    }
}
