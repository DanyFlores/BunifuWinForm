using System;
using Capa_Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace Capa_Datos
{
    public class CategoriaDatos
    {
        public List<Categoria> ObtenerListaCategoria(string conexion)
        {
            try
            {
                List<Categoria> Lista = new List<Categoria>();
                Categoria item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(conexion, "[dbo].[sp_get_Categoria]");
                while (Dr.Read())
                {
                    item = new Categoria();
                    item.idCategoria = Dr.IsDBNull(Dr.GetOrdinal("idCategoria")) ? 0 : Dr.GetInt32(Dr.GetOrdinal("idCategoria"));
                    item.Codigo = Dr.IsDBNull(Dr.GetOrdinal("Codigo")) ? string.Empty : Dr.GetString(Dr.GetOrdinal("Codigo"));
                    item.Nombre = Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? string.Empty : Dr.GetString(Dr.GetOrdinal("Nombre"));
                    item.Descripcion = Dr.IsDBNull(Dr.GetOrdinal("Descripcion")) ? string.Empty : Dr.GetString(Dr.GetOrdinal("Descripcion"));
                   
                    Lista.Add(item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categoria> ObtenerListaCategoriaSearch(string conexion, string buscar)
        {
            try
            {
                List<Categoria> Lista = new List<Categoria>();
                Categoria item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(conexion, "[dbo].[sp_BuscarCategoria]", buscar);
                while (Dr.Read())
                {
                    item = new Categoria();
                    item.idCategoria = Dr.IsDBNull(Dr.GetOrdinal("idCategoria")) ? 0 : Dr.GetInt32(Dr.GetOrdinal("idCategoria"));
                    item.Codigo = Dr.IsDBNull(Dr.GetOrdinal("Codigo")) ? string.Empty : Dr.GetString(Dr.GetOrdinal("Codigo"));
                    item.Nombre = Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? string.Empty : Dr.GetString(Dr.GetOrdinal("Nombre"));
                    item.Descripcion = Dr.IsDBNull(Dr.GetOrdinal("Descripcion")) ? string.Empty : Dr.GetString(Dr.GetOrdinal("Descripcion"));

                    Lista.Add(item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ABCCategoria(Categoria _categoria,ref int verificador)
        {
            try
            {
                object [] Value = {_categoria.Nombre,_categoria.Descripcion,_categoria.idCategoria,_categoria.opcion};
                object res = SqlHelper.ExecuteScalar(_categoria.conexion, "[dbo].[sp_ABC_Categoria]", Value);
                if(res != null)
                {
                    verificador = 0;
                }                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
