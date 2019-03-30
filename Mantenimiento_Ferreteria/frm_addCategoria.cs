using System;
using Capa_Entidad;
using Capa_Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Ferreteria
{
    public partial class frm_addCategoria : Form
    {
        private Categoria _categoria;        
        public frm_addCategoria(Categoria cat)
        {
            InitializeComponent();
            _categoria = cat;
        }
        private void frm_addCategoria_Load(object sender, EventArgs e)
        {
            try
            {          
                this.txt_Codigo.Enabled = false;
                if(_categoria.idCategoria != 0)
                    CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Metodos
        public bool validarCampos()
        {
            try
            {
                if (this.txt_Nombre.Text.Length == 0)
                {
                    this.txt_Nombre.Focus();
                    MessageBox.Show("El campo Nombre no debe ser vacio", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }else if (this.txt_Descripcion.Text.Length == 0)
                {
                    this.txt_Descripcion.Focus();
                    MessageBox.Show("El campo Descripción no debe ser vacio", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarDatos()
        {
            try
            {               
                this.txt_Codigo.Text = _categoria.Codigo;
                this.txt_Nombre.Text = _categoria.Nombre;
                this.txt_Descripcion.Text = _categoria.Descripcion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos
        public void GuardarDatos()
        {
            try
            {
                int verificador = -1;                
                _categoria.conexion = Comun.conexion;          
                this.ObtenerDatos(_categoria);
                CategoriaNegocio _catNegocio = new CategoriaNegocio();
                if(_categoria.idCategoria != 0)
                {
                    _categoria.opcion = 2;
                    _catNegocio.ABCCategoria(_categoria, ref verificador);
                    if (verificador == 0)
                    {
                        MessageBox.Show("Datos Modificados Correctamente");
                        this.Close();
                    }
                }
                else
                {
                    _categoria.opcion = 1;
                    _catNegocio.ABCCategoria(_categoria, ref verificador);
                    if (verificador == 0)
                    {
                        MessageBox.Show("Datos Guardados Correctamente");
                        this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerDatos(Categoria _categoria)
        {
            try
            {
                _categoria.idCategoria = _categoria.idCategoria;
                _categoria.Codigo = txt_Codigo.Text;
                _categoria.Nombre = this.txt_Nombre.Text;
                _categoria.Descripcion = this.txt_Descripcion.Text;
                _categoria.id_user = Comun.usuario;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void pb_Close_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validarCampos())
                {
                    this.GuardarDatos();                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
