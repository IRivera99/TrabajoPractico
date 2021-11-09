using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDatos.Dominio
{
    public class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string Nombre { get; set; }

        public Asignatura()
        {
            IdAsignatura = 0;
            Nombre = string.Empty;
        }

        public Asignatura(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }

    }

}
