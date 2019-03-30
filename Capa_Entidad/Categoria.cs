using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Categoria
    {
        private int _idCategoria;
        public int idCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        private string _Codigo;
        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private string _conexion;
        public string conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

        private int _opcion;
        public int opcion
        {
            get { return _opcion; }
            set { _opcion = value; }
        }

        private string _id_user;
        public string id_user
        {
            get { return _id_user; }
            set { _id_user = value; }
        }       
    }
}
