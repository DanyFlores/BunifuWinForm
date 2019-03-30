namespace Mantenimiento_Ferreteria
{
    partial class frm_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Categoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1tOP = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.MOVERFORM = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dtg_Categoria = new System.Windows.Forms.DataGridView();
            this.column_IDcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1tOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Categoria)).BeginInit();
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
            this.panel1tOP.Size = new System.Drawing.Size(800, 32);
            this.panel1tOP.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Titulo.Location = new System.Drawing.Point(3, 4);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(124, 22);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "CATEGORIA";
            // 
            // pb_Close
            // 
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(751, 2);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(48, 28);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Close.TabIndex = 1;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // MOVERFORM
            // 
            this.MOVERFORM.Fixed = true;
            this.MOVERFORM.Horizontal = true;
            this.MOVERFORM.TargetControl = this.panel1tOP;
            this.MOVERFORM.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(752, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(528, 56);
            this.txt_Buscar.Multiline = true;
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(218, 20);
            this.txt_Buscar.TabIndex = 3;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // dtg_Categoria
            // 
            this.dtg_Categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Categoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Categoria.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Categoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_IDcategoria,
            this.column_Codigo,
            this.Column_Nombre,
            this.Column_Descripcion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Categoria.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Categoria.Location = new System.Drawing.Point(7, 106);
            this.dtg_Categoria.Name = "dtg_Categoria";
            this.dtg_Categoria.RowHeadersVisible = false;
            this.dtg_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Categoria.Size = new System.Drawing.Size(781, 250);
            this.dtg_Categoria.TabIndex = 4;
            // 
            // column_IDcategoria
            // 
            this.column_IDcategoria.DataPropertyName = "idCategoria";
            this.column_IDcategoria.HeaderText = "idCategoria";
            this.column_IDcategoria.Name = "column_IDcategoria";
            this.column_IDcategoria.Visible = false;
            // 
            // column_Codigo
            // 
            this.column_Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Codigo.DataPropertyName = "Codigo";
            this.column_Codigo.HeaderText = "CODIGO";
            this.column_Codigo.Name = "column_Codigo";
            // 
            // Column_Nombre
            // 
            this.Column_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Nombre.DataPropertyName = "Nombre";
            this.Column_Nombre.HeaderText = "NOMBRE";
            this.Column_Nombre.Name = "Column_Nombre";
            // 
            // Column_Descripcion
            // 
            this.Column_Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Descripcion.DataPropertyName = "Descripcion";
            this.Column_Descripcion.HeaderText = "DESCRIPCION";
            this.Column_Descripcion.Name = "Column_Descripcion";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.Color.Red;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.BorderRadius = 7;
            this.btn_Eliminar.ButtonText = "ELIMINAR";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Iconimage")));
            this.btn_Eliminar.Iconimage_right = null;
            this.btn_Eliminar.Iconimage_right_Selected = null;
            this.btn_Eliminar.Iconimage_Selected = null;
            this.btn_Eliminar.IconMarginLeft = 0;
            this.btn_Eliminar.IconMarginRight = 0;
            this.btn_Eliminar.IconRightVisible = true;
            this.btn_Eliminar.IconRightZoom = 0D;
            this.btn_Eliminar.IconVisible = true;
            this.btn_Eliminar.IconZoom = 70D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(587, 377);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.Red;
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(201, 48);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.White;
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Editar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.BorderRadius = 7;
            this.btn_Editar.ButtonText = "EDITAR";
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Iconimage")));
            this.btn_Editar.Iconimage_right = null;
            this.btn_Editar.Iconimage_right_Selected = null;
            this.btn_Editar.Iconimage_Selected = null;
            this.btn_Editar.IconMarginLeft = 0;
            this.btn_Editar.IconMarginRight = 0;
            this.btn_Editar.IconRightVisible = true;
            this.btn_Editar.IconRightZoom = 0D;
            this.btn_Editar.IconVisible = true;
            this.btn_Editar.IconZoom = 70D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(377, 377);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Editar.OnHovercolor = System.Drawing.Color.Navy;
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(201, 48);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "NUEVO";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(170, 377);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(201, 48);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Text = "NUEVO";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // frm_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dtg_Categoria);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1tOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Categoria";
            this.Load += new System.EventHandler(this.frm_Categoria_Load);
            this.panel1tOP.ResumeLayout(false);
            this.panel1tOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1tOP;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuDragControl MOVERFORM;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtg_Categoria;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_IDcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Descripcion;
    }
}