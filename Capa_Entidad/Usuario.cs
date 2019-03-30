using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        private string _id_usuario;
        public string id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        private string _id_personal;
        public string id_personal
        {
            get { return _id_personal; }
            set { _id_personal = value; }
        }

        private string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _Conexion;
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

        private int _resultadoLogin = 1;
        public int resultadoLogin
        {
            get { return _resultadoLogin; }
            set { _resultadoLogin = value; }
        }
    }
}
