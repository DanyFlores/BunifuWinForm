using Capa_Entidad;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ObtenerListaCategoria(string conexion)
        {
            try
            {
                CategoriaDatos catDatos = new CategoriaDatos();
                return catDatos.ObtenerListaCategoria(conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public List<Categoria> ObtenerListaCategoriaShear(string conexion,string buscar)
        {
            try
            {
                CategoriaDatos _catDatos = new CategoriaDatos();
                return _catDatos.ObtenerListaCategoriaSearch(conexion,buscar);
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
                CategoriaDatos _catDatos = new CategoriaDatos();
                _catDatos.ABCCategoria(_categoria,ref verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
