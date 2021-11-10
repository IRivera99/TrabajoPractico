using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Dominio
{
    class Carrera
    {
        public int IdCarrera { get; set; }
        public string NCarrera { get; set; }

        public Carrera()
        {
            IdCarrera = 0;
            NCarrera = string.Empty;
        }
    }
}
