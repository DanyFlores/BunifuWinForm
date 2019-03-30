using System;
using Capa_Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using System.Configuration;

namespace Mantenimiento_Ferreteria
{
    public partial class frm_Categoria : Form
    {
        public frm_Categoria()
        {
            InitializeComponent();
            Comun.conexion = ConfigurationManager.AppSettings.Get("strConnection");
        }
        private void frm_Categoria_Load(object sender, EventArgs e)
        {
            try
            {
                this.LLegarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        #region Metodos Generales       
        private void LLegarGrid()
        {
            try
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                List<Categoria> Lista = catNegocio.ObtenerListaCategoria(Comun.conexion);
                dtg_Categoria.AutoGenerateColumns = false;
                dtg_Categoria.DataSource = Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LLegarGridXShear()
        {
            try
            {             
                string buscar = txt_Buscar.Text;
                CategoriaNegocio _catNegocio = new CategoriaNegocio();                 
                List<Categoria> ListaBuscar = _catNegocio.ObtenerListaCategoriaShear(Comun.conexion,buscar);
                dtg_Categoria.AutoGenerateColumns = false;
                dtg_Categoria.DataSource = ListaBuscar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<DataGridViewRow> ObtenerFilaSeleccionada()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dtg_Categoria.Rows)
                {
                    if (row.Selected)
                    {
                        rowSelected.Add(row);
                    }
                }
                return rowSelected;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFilaSeleccionada(List<DataGridViewRow> rowSelected)
        {
            try
            {
                if (rowSelected.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila del grid", "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Categoria obtenerDatosGrid()
        {
            try
            {
                Categoria _categoria = new Categoria();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    _categoria.idCategoria = Convert.ToInt32(row.Cells["column_IDcategoria"].Value.ToString());
                    _categoria.Codigo = row.Cells["Column_Codigo"].Value.ToString();
                    _categoria.Nombre = row.Cells["Column_Nombre"].Value.ToString();
                    _categoria.Descripcion = row.Cells["Column_Descripcion"].Value.ToString();
                    _categoria.id_user = Comun.id_usuario;
                }
                return _categoria;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EliminarCategoria(Categoria _categoria)
        {
            try
            {
                int verificador = -1;              
                _categoria.conexion = Comun.conexion;
                _categoria.opcion = 3;
                CategoriaNegocio _catNegocio = new CategoriaNegocio();           
                _catNegocio.ABCCategoria(_categoria, ref verificador);
                if (verificador == 0)
                {
                    MessageBox.Show("Datos Eliminados Correctamente");
                    this.LLegarGrid();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                frm_addCategoria addCategoria = new frm_addCategoria(new Categoria());
                addCategoria.ShowDialog();
                this.LLegarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Buscar.Text.Length == 0)
                {
                    this.LLegarGrid();
                }
                else
                {
                    this.LLegarGridXShear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarFilaSeleccionada(this.ObtenerFilaSeleccionada()))
                {
                    frm_addCategoria _modificarCat = new frm_addCategoria(this.obtenerDatosGrid());
                    _modificarCat.ShowDialog();

                    this.LLegarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarFilaSeleccionada(this.ObtenerFilaSeleccionada()))
                {
                    if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {                    
                        this.EliminarCategoria(this.obtenerDatosGrid());                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }

}
