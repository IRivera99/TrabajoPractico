using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using LibreriaDatos.Servicios;
using LibreriaDatos.Dominio;

namespace LibreriaDatos.Datos
{
	class HelperDao
	{
		private static HelperDao instancia;
		private string cadenaConexion;
		SqlConnection cnn;
		SqlCommand cmd;

		private HelperDao()
		{
			cadenaConexion = @"Data Source=NACHO\SQLEXPRESS01;Initial Catalog=CarreraDB;Integrated Security=True";
			cnn = new SqlConnection(cadenaConexion);
			cmd = new SqlCommand();
		}

		public static HelperDao ObtenerInstancia()
		{
			if (instancia == null)
			{
				instancia = new HelperDao();
			}
			return instancia;
		}

		public DataTable ConsultaSQL(string nombreSP)
		{
			DataTable tabla = new DataTable();
			try
			{
				cmd.Parameters.Clear();
				cnn.Open();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = nombreSP;
				tabla.Load(cmd.ExecuteReader());
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return tabla;
		}

		public DataTable BusquedaSQL(string nombreSp, int id, string nParamId)
        {
			DataTable tabla = new DataTable();
			try
			{
				cmd.Parameters.Clear();
				cnn.Open();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = nombreSp;
				cmd.Parameters.AddWithValue(nParamId, id);				
				tabla.Load(cmd.ExecuteReader());
			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return tabla;
		}

		public int EjecutarSQLMaestroDetalle(string spM, string spD, Carrera oCarrera, Parametros.Accion accion)
		{
			int filasA = 0;
			SqlTransaction trans = null;

			try
			{
				cmd.Parameters.Clear();
				cnn.Open();
				trans = cnn.BeginTransaction();
				cmd.Connection = cnn;
				cmd.Transaction = trans;
				cmd.CommandText = spM;
				cmd.CommandType = CommandType.StoredProcedure;

				if (accion == Parametros.Accion.Crear)
                {
					SqlParameter param = new SqlParameter("@idCarrera", SqlDbType.Int);
					param.Direction = ParameterDirection.Output;
					cmd.Parameters.AddWithValue("@nCarrera", oCarrera.Nombre);
					cmd.Parameters.AddWithValue("@titulo", oCarrera.Titulo);
					cmd.Parameters.Add(param);
					cmd.ExecuteNonQuery();
					oCarrera.IdCarrera = (int)param.Value;
				}
				if (accion == Parametros.Accion.Modificar)
				{
					cmd.Parameters.AddWithValue("@idCarrera", oCarrera.IdCarrera);
					cmd.Parameters.AddWithValue("@nCarrera", oCarrera.Nombre);
					cmd.Parameters.AddWithValue("@titulo", oCarrera.Titulo);
					cmd.ExecuteNonQuery();
				}

				foreach (DetalleCarrera item in oCarrera.DetalleCarrera)
				{
					SqlCommand cmdDC = new SqlCommand();
					cmdDC.Connection = cnn;
					cmdDC.Transaction = trans;
					cmdDC.CommandText = spD;
					cmdDC.CommandType = CommandType.StoredProcedure;
					cmdDC.Parameters.AddWithValue("@idCarrera", oCarrera.IdCarrera);
					cmdDC.Parameters.AddWithValue("@idAsignatura", item.Asignatura.IdAsignatura);
					cmdDC.Parameters.AddWithValue("@aCursado", item.Año);
					cmdDC.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
					filasA = cmdDC.ExecuteNonQuery();
				}

				trans.Commit();
			}
			catch (Exception e)
			{
				string mensaje = e.Message;
				trans.Rollback();
				filasA = 0;
				throw;
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return filasA;
		}

		public int ProximoID(string nombreSP, string nParam)
		{
			SqlParameter param = new SqlParameter(nParam, SqlDbType.Int);
			try
			{
				cmd.Parameters.Clear();
				cnn.Open();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = nombreSP;
				param.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(param);
				cmd.ExecuteNonQuery();
				return (int)param.Value;
			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
		}

		public bool Borrar(string nomSP,int nroID, string nParamID)
		{
			SqlTransaction trans = null;			
			try
			{
				cnn.Open();
				trans = cnn.BeginTransaction();
				SqlCommand cmd = new SqlCommand(nomSP, cnn, trans);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(nParamID, nroID);
				cmd.ExecuteNonQuery();
				trans.Commit();

			}
			catch (SqlException ex)
			{
				trans.Rollback();
				return false;
				throw;
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return true;
		}

		public bool Modificar(string nomSP, int Id, string nParamID, string dato, string nParamDato)
        {
			SqlTransaction trans = null;
			int filasA = 0;
			try
			{
				cnn.Open();
				trans = cnn.BeginTransaction();
				SqlCommand cmd = new SqlCommand(nomSP, cnn, trans);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(nParamID, Id);
				cmd.Parameters.AddWithValue(nParamDato, dato);
				filasA = cmd.ExecuteNonQuery();
				trans.Commit();

			}
			catch (SqlException ex)
			{
				trans.Rollback();
				throw;
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return filasA == 1;
		}

		public bool ModificarVarios(string nomSP, int id, string nParamId, List<string> datos, List<string> nParamDatos)
        {
			if(datos.Count != nParamDatos.Count)
            {
				return false;
            }
			SqlTransaction trans = null;
			int filasA = 0;
			try
			{
				cnn.Open();
				trans = cnn.BeginTransaction();
				SqlCommand cmd = new SqlCommand(nomSP, cnn, trans);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(nParamId, id);
                for (int i = 0; i < datos.Count; i++)
                {
					cmd.Parameters.AddWithValue(nParamDatos[i], datos[i]);
				}
				filasA = cmd.ExecuteNonQuery();
				trans.Commit();

			}
			catch (SqlException ex)
			{
				trans.Rollback();
				throw;
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return filasA == 1;
		}

		public bool InsertarAsignatura(string nomSP, List<Asignatura> lst)
        {
			SqlTransaction trans = null;
			bool flag = true;
            try
            {
				cnn.Open();
				trans = cnn.BeginTransaction();
				foreach (Asignatura oAsignatura in lst)
                {
					SqlCommand cmd = new SqlCommand(nomSP,cnn,trans);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@nombre", oAsignatura.Nombre);
					cmd.ExecuteNonQuery();
				}
				trans.Commit();
            }
            catch (SqlException)
            {
				trans.Rollback();
				flag = false;
            }
            finally
            {
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return flag;
        }

		public bool ValidarUsuario(string nSp, string nombre, string contraseña)
        {
			bool flag = false;
			SqlTransaction trans = null;
			SqlParameter param = new SqlParameter("@valido", SqlDbType.Bit);
            try
            {
				cnn.Open();
				trans = cnn.BeginTransaction();
				SqlCommand cmd = new SqlCommand(nSp, cnn, trans);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@usuario", nombre);
				cmd.Parameters.AddWithValue("@contraseña", contraseña);
				param.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(param);
				cmd.ExecuteNonQuery();
				if((bool)param.Value)
                {
					flag = true;
                }
				trans.Commit();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
				if (cnn != null && cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return flag;
        }
	}
}
