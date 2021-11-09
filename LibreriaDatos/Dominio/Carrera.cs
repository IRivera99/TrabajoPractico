using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDatos.Dominio
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public List<DetalleCarrera> DetalleCarrera { get; set; }

        public Carrera()
        {
            DetalleCarrera = new List<DetalleCarrera>();
        }

        public void QuitarAsignatura(int indice)
        {
           DetalleCarrera.RemoveAt(indice);
        }

        public void AgregarAsignatura(DetalleCarrera detalleCarrera)
        {
            DetalleCarrera.Add(detalleCarrera);
        }

    }
}
