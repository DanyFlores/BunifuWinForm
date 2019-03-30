namespace Mantenimiento_Ferreteria
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(56, 100);
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(374, 35);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(56, 167);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(374, 35);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.BorderRadius = 0;
            this.btn_Aceptar.ButtonText = "ACEPTAR";
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Aceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.Iconimage")));
            this.btn_Aceptar.Iconimage_right = null;
            this.btn_Aceptar.Iconimage_right_Selected = null;
            this.btn_Aceptar.Iconimage_Selected = null;
            this.btn_Aceptar.IconMarginLeft = 0;
            this.btn_Aceptar.IconMarginRight = 0;
            this.btn_Aceptar.IconRightVisible = true;
            this.btn_Aceptar.IconRightZoom = 0D;
            this.btn_Aceptar.IconVisible = true;
            this.btn_Aceptar.IconZoom = 90D;
            this.btn_Aceptar.IsTab = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(229, 214);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Aceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Aceptar.selected = false;
            this.btn_Aceptar.Size = new System.Drawing.Size(201, 48);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "ACEPTAR";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Aceptar.Textcolor = System.Drawing.Color.White;
            this.btn_Aceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.BorderRadius = 0;
            this.btn_Cancelar.ButtonText = "CANCELAR";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Iconimage")));
            this.btn_Cancelar.Iconimage_right = null;
            this.btn_Cancelar.Iconimage_right_Selected = null;
            this.btn_Cancelar.Iconimage_Selected = null;
            this.btn_Cancelar.IconMarginLeft = 0;
            this.btn_Cancelar.IconMarginRight = 0;
            this.btn_Cancelar.IconRightVisible = true;
            this.btn_Cancelar.IconRightZoom = 0D;
            this.btn_Cancelar.IconVisible = true;
            this.btn_Cancelar.IconZoom = 45D;
            this.btn_Cancelar.IsTab = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(56, 214);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Normalcolor = System.Drawing.Color.Red;
            this.btn_Cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cancelar.selected = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(148, 48);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Textcolor = System.Drawing.Color.White;
            this.btn_Cancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Titulo.Location = new System.Drawing.Point(124, -1);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(229, 33);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "ADMINISTRADOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lbl_Titulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(484, 32);
            this.panelTop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.panelTop;
            this.MoverFormulario.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(484, 291);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_pass;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Aceptar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cancelar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}