using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace regEstablecimientos
{
    class entidades
    {
        public class Ciudad
        {
            public int idCiudad { get; set; }
            public string nombreCiudad { get; set; }
        }

        public class Localidad
        {
            public int idLocalidad { get; set; }
            public string nombreLocalidad { get; set; }
        }
    }
}
