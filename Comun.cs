using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public static class Comun
    {
        private static string _conexion;
        public static string conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

    }
}
