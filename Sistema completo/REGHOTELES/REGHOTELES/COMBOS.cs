using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace REGHOTELES
{
    class COMBOS
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
        public class Categoria
        {    
            public string categoria { get; set; }
        }
        public class CategoriaLoc
        {
            public string categoria { get; set; }
        }
        public class Localidades
        {
            public string nombreLocalidad{ get; set; }
        }

    }


 }

