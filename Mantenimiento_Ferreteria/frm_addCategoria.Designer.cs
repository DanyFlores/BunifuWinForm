namespace Mantenimiento_Ferreteria
{
    partial class frm_addCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addCategoria));
            this.panel1tOP = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.pb_Codigo = new System.Windows.Forms.PictureBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Regresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1tOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Codigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1tOP
            // 
            this.panel1tOP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1tOP.Controls.Add(this.lbl_Titulo);
            this.panel1tOP.Controls.Add(this.pb_Close);
            this.panel1tOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1tOP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1tOP.Location = new System.Drawing.Point(0, 0);
            this.panel1tOP.Name = "panel1tOP";
            this.panel1tOP.Size = new System.Drawing.Size(689, 32);
            this.panel1tOP.TabIndex = 1;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Titulo.Location = new System.Drawing.Point(3, 4);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(195, 22);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "NUEVA CATEGORIA";
            // 
            // pb_Close
            // 
            this.pb_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(632, 1);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(48, 28);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Close.TabIndex = 1;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(67, 90);
            this.txt_Codigo.Multiline = true;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(151, 20);
            this.txt_Codigo.TabIndex = 5;
            // 
            // pb_Codigo
            // 
            this.pb_Codigo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Codigo.Image")));
            this.pb_Codigo.Location = new System.Drawing.Point(56, 79);
            this.pb_Codigo.Name = "pb_Codigo";
            this.pb_Codigo.Size = new System.Drawing.Size(173, 40);
            this.pb_Codigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Codigo.TabIndex = 4;
            this.pb_Codigo.TabStop = false;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(315, 90);
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(302, 20);
            this.txt_Nombre.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(304, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(311, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(56, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(324, 161);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(67, 167);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(302, 145);
            this.txt_Descripcion.TabIndex = 9;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1tOP;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.BorderRadius = 7;
            this.btn_Guardar.ButtonText = "GUARDAR";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Iconimage")));
            this.btn_Guardar.Iconimage_right = null;
            this.btn_Guardar.Iconimage_right_Selected = null;
            this.btn_Guardar.Iconimage_Selected = null;
            this.btn_Guardar.IconMarginLeft = 0;
            this.btn_Guardar.IconMarginRight = 0;
            this.btn_Guardar.IconRightVisible = true;
            this.btn_Guardar.IconRightZoom = 0D;
            this.btn_Guardar.IconVisible = true;
            this.btn_Guardar.IconZoom = 70D;
            this.btn_Guardar.IsTab = false;
            this.btn_Guardar.Location = new System.Drawing.Point(427, 173);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Guardar.selected = false;
            this.btn_Guardar.Size = new System.Drawing.Size(201, 48);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.btn_Guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Activecolor = System.Drawing.Color.Red;
            this.btn_Regresar.BackColor = System.Drawing.Color.Red;
            this.btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Regresar.BorderRadius = 7;
            this.btn_Regresar.ButtonText = "REGRESAR";
            this.btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Regresar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Regresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Regresar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Regresar.Iconimage")));
            this.btn_Regresar.Iconimage_right = null;
            this.btn_Regresar.Iconimage_right_Selected = null;
            this.btn_Regresar.Iconimage_Selected = null;
            this.btn_Regresar.IconMarginLeft = 0;
            this.btn_Regresar.IconMarginRight = 0;
            this.btn_Regresar.IconRightVisible = true;
            this.btn_Regresar.IconRightZoom = 0D;
            this.btn_Regresar.IconVisible = true;
            this.btn_Regresar.IconZoom = 70D;
            this.btn_Regresar.IsTab = false;
            this.btn_Regresar.Location = new System.Drawing.Point(427, 255);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Normalcolor = System.Drawing.Color.Red;
            this.btn_Regresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Regresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Regresar.selected = false;
            this.btn_Regresar.Size = new System.Drawing.Size(201, 48);
            this.btn_Regresar.TabIndex = 11;
            this.btn_Regresar.Text = "REGRESAR";
            this.btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Regresar.Textcolor = System.Drawing.Color.White;
            this.btn_Regresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // frm_addCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 348);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.pb_Codigo);
            this.Controls.Add(this.panel1tOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_addCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addCategoria";
            this.Load += new System.EventHandler(this.frm_addCategoria_Load);
            this.panel1tOP.ResumeLayout(false);
            this.panel1tOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Codigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1tOP;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.PictureBox pb_Codigo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Guardar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Regresar;
    }
}