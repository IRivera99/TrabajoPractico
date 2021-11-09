using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDatos.Dominio
{
    public class DetalleCarrera
    {
        public Asignatura Asignatura { get; set; }
        public int Año { get; set; }
        public int Cuatrimestre { get; set; }

        public DetalleCarrera()
        {
            Asignatura = new Asignatura();
            Año = 0;
            Cuatrimestre = 0;
        }
    }
}
