using Capa_Entidad;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class LoginNegocio
    {
        public void resultadoLogin( Usuario _user)
        {
            try
            {
                LoginDatos login_datos = new LoginDatos();
                login_datos.resultadoLogin(_user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
