using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Sucursal
    {
        private string _id_sucursal;
        public string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }

        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _telefono;
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _codigo;
        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

    }
}
