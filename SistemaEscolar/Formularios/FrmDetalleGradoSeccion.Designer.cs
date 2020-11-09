namespace SistemaEscolar.Formularios
{
    partial class FrmDetalleGradoSeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleGradoSeccion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBSalir = new System.Windows.Forms.PictureBox();
            this.picBMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAnio = new System.Windows.Forms.DateTimePicker();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdProfesor = new System.Windows.Forms.Label();
            this.lblIdSeccion = new System.Windows.Forms.Label();
            this.lblIdGrado = new System.Windows.Forms.Label();
            this.lblIdDetalle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(164)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.picBSalir);
            this.panel1.Controls.Add(this.picBMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 74);
            this.panel1.TabIndex = 0;
            // 
            // picBSalir
            // 
            this.picBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBSalir.Image = ((System.Drawing.Image)(resources.GetObject("picBSalir.Image")));
            this.picBSalir.Location = new System.Drawing.Point(887, 19);
            this.picBSalir.Name = "picBSalir";
            this.picBSalir.Size = new System.Drawing.Size(40, 42);
            this.picBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBSalir.TabIndex = 28;
            this.picBSalir.TabStop = false;
            this.picBSalir.Click += new System.EventHandler(this.picBSalir_Click);
            // 
            // picBMinimizar
            // 
            this.picBMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimizar.Image")));
            this.picBMinimizar.Location = new System.Drawing.Point(836, 19);
            this.picBMinimizar.Name = "picBMinimizar";
            this.picBMinimizar.Size = new System.Drawing.Size(45, 42);
            this.picBMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMinimizar.TabIndex = 27;
            this.picBMinimizar.TabStop = false;
            this.picBMinimizar.Click += new System.EventHandler(this.picBMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grado:";
            // 
            // cmbGrado
            // 
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(218, 94);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(197, 29);
            this.cmbGrado.TabIndex = 1;
            this.cmbGrado.SelectedIndexChanged += new System.EventHandler(this.cmbGrado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sección:";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(218, 132);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(197, 29);
            this.cmbSeccion.TabIndex = 1;
            this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Profesor encargado:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(218, 179);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(197, 29);
            this.cmbProfesor.TabIndex = 1;
            this.cmbProfesor.SelectedIndexChanged += new System.EventHandler(this.cmbProfesor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Año escolar:";
            // 
            // dtpAnio
            // 
            this.dtpAnio.CustomFormat = "yyyy";
            this.dtpAnio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnio.Location = new System.Drawing.Point(218, 223);
            this.dtpAnio.Name = "dtpAnio";
            this.dtpAnio.ShowUpDown = true;
            this.dtpAnio.Size = new System.Drawing.Size(200, 27);
            this.dtpAnio.TabIndex = 2;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(461, 94);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(471, 232);
            this.dgvDetalles.TabIndex = 3;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(18, 353);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(397, 33);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(461, 353);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(164, 33);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(756, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 33);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblIdProfesor
            // 
            this.lblIdProfesor.AutoSize = true;
            this.lblIdProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdProfesor.Location = new System.Drawing.Point(424, 184);
            this.lblIdProfesor.Name = "lblIdProfesor";
            this.lblIdProfesor.Size = new System.Drawing.Size(35, 13);
            this.lblIdProfesor.TabIndex = 5;
            this.lblIdProfesor.Text = "label6";
            this.lblIdProfesor.Click += new System.EventHandler(this.lblIdProfesor_Click);
            // 
            // lblIdSeccion
            // 
            this.lblIdSeccion.AutoSize = true;
            this.lblIdSeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdSeccion.Location = new System.Drawing.Point(424, 139);
            this.lblIdSeccion.Name = "lblIdSeccion";
            this.lblIdSeccion.Size = new System.Drawing.Size(35, 13);
            this.lblIdSeccion.TabIndex = 6;
            this.lblIdSeccion.Text = "label7";
            this.lblIdSeccion.Click += new System.EventHandler(this.lblIdSeccion_Click);
            // 
            // lblIdGrado
            // 
            this.lblIdGrado.AutoSize = true;
            this.lblIdGrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdGrado.Location = new System.Drawing.Point(420, 103);
            this.lblIdGrado.Name = "lblIdGrado";
            this.lblIdGrado.Size = new System.Drawing.Size(35, 13);
            this.lblIdGrado.TabIndex = 7;
            this.lblIdGrado.Text = "label8";
            this.lblIdGrado.Click += new System.EventHandler(this.lblIdGrado_Click);
            // 
            // lblIdDetalle
            // 
            this.lblIdDetalle.AutoSize = true;
            this.lblIdDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdDetalle.Location = new System.Drawing.Point(578, 75);
            this.lblIdDetalle.Name = "lblIdDetalle";
            this.lblIdDetalle.Size = new System.Drawing.Size(35, 13);
            this.lblIdDetalle.TabIndex = 8;
            this.lblIdDetalle.Text = "label6";
            this.lblIdDetalle.Click += new System.EventHandler(this.lblIdDetalle_Click);
            // 
            // FrmDetalleGradoSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 422);
            this.Controls.Add(this.lblIdDetalle);
            this.Controls.Add(this.lblIdGrado);
            this.Controls.Add(this.lblIdSeccion);
            this.Controls.Add(this.lblIdProfesor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dtpAnio);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetalleGradoSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleGradoSeccion";
            this.Load += new System.EventHandler(this.FrmDetalleGradoSeccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBSalir;
        private System.Windows.Forms.PictureBox picBMinimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAnio;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblIdGrado;
        private System.Windows.Forms.Label lblIdSeccion;
        private System.Windows.Forms.Label lblIdProfesor;
        private System.Windows.Forms.Label lblIdDetalle;
    }
}