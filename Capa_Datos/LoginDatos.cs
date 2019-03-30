using Capa_Entidad;
using System;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class LoginDatos
    {
        public void resultadoLogin(Usuario usuario)
        {
            try
            {
                SqlDataReader SqlDr = null;
                string[] valores = { usuario.usuario, usuario.password};

                SqlDr = SqlHelper.ExecuteReader(usuario.Conexion, "[dbo].[LoginAdmin_sp]", valores);
                while (SqlDr.Read())
                {
                    usuario.resultadoLogin = SqlDr.GetInt32(0);
                    if (usuario.resultadoLogin == 0)
                    {
                        Comun.id_usuario = SqlDr.GetString(SqlDr.GetOrdinal("id_usuario"));
                        Comun.id_tipoUsuario = SqlDr.GetInt32(SqlDr.GetOrdinal("id_tipoUsuario"));
                        Comun.usuario_nombre = SqlDr.GetString(SqlDr.GetOrdinal("usuario_nombre"));
                        Comun.usuario_apellidoPat = SqlDr.GetString(SqlDr.GetOrdinal("usuario_apellidoPat"));
                        Comun.usuario_apellidoMat = SqlDr.GetString(SqlDr.GetOrdinal("usuario_apellidoMat"));
                        Comun.usuario = SqlDr.GetString(SqlDr.GetOrdinal("usuario"));
                        Comun.password = SqlDr.GetString(SqlDr.GetOrdinal("password"));
                        Comun.id_sucursal = SqlDr.GetString(SqlDr.GetOrdinal("id_sucursal"));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
