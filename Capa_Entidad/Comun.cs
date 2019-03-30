using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public static class Comun
    {
        private static string _id_usuario;
        public static string id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        private static string _usuario;
        public static string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private static string _password;
        public static string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private static string _usuario_nombre;
        public static string usuario_nombre
        {
            get { return _usuario_nombre; }
            set { _usuario_nombre = value; }
        }

        private static string _usuario_apellidoPat;
        public static string usuario_apellidoPat
        {
            get { return _usuario_apellidoPat; }
            set { _usuario_apellidoPat = value; }
        }

        private static string _usuario_apellidoMat;
        public static string usuario_apellidoMat
        {
            get { return _usuario_apellidoMat; }
            set { _usuario_apellidoMat = value; }
        }

        private static int _id_tipoUsuario;
        public static int id_tipoUsuario
        {
            get { return _id_tipoUsuario; }
            set { _id_tipoUsuario = value; }
        }

        private static string _id_sucursal;
        public static string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }

        private static string _conexion;
        public static string conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

    }
}
