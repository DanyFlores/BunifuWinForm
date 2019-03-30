using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Configuration;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.txt_usuario.Focus();
            Comun.conexion = ConfigurationManager.AppSettings.Get("strConnection");
        }

        #region Metodos
        
        #endregion

        #region Eventos
        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario _user = new Usuario();
                _user.Conexion = Comun.conexion;
                _user.usuario = this.txt_usuario.Text;
                _user.password = this.txt_pass.Text;
                LoginNegocio _loginNegocio = new LoginNegocio();
                _loginNegocio.resultadoLogin(_user);

                switch (_user.resultadoLogin)
                {
                    case 0:
                        _user.id_usuario = Comun.id_usuario;
                        frm_Categoria frm_categoria = new frm_Categoria();
                        frm_categoria.ShowDialog();
                        frm_categoria.Dispose();
                        Application.Exit();
                        break;
                    case 1:
                        MessageBox.Show("No existe la cuenta");
                        //this.txt_mensaje.Text = "No existe la cuenta";
                        break;
                    case 2:
                        MessageBox.Show("Contraseña incorrecta");
                        //this.txt_mensaje.Visible = true;
                        //this.txt_mensaje.Text = "Contraseña incorrecta";
                        break;
                    case 3:
                        MessageBox.Show("Su cuenta no tiene permisos de administrador");

                        //this.txt_mensaje.Visible = true;
                        //this.txt_mensaje.Text = "Su cuenta no tiene permisos de administrador";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txt_usuario.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sistema Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

